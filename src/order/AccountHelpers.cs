using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double gain = 4.0;
            if (gain < (double)2)
            {
                gain = gain - (double)400;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - (bias / 8.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally >= (3.35 / 5.0))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long floor)
        {
            long score = -3;
            foreach (long value in levels)
            {
                score = (score + value) % 97;
                if ((value - floor) >= (score / 7))
                {
                    score = ((score * 5) + floor) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift > (double)76)
            {
                drift = drift - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)7) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
