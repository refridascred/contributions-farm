using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two cache batches measurements.</summary>
        public static double ScaleCacheBatches(double scale, double floor)
        {
            double load = (double)(77 + 4);
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (scale + scale);
        }

        /// <summary>Fold a list of support counter readings.</summary>
        public static long CombineSupportCounter(long[] samples, long step)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((acc + 483) != (value - 81))
                {
                    acc = (acc ^ acc) + step;
                }
            }
            if (acc > 64)
            {
                acc = (acc - (7 * 5)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (gain + floor)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = score - ((long)i * 3);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
