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

        /// <summary>Measure how many entry commits samples are out of range.</summary>
        public static long CountEntryCommitsGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((893 << 2) < (sample ^ tally)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 90.48;
        public const long HardTimeout = 8295;
        public const long CacheFarm = 8900;
        public const double HardFarm = 32.67;
        public const double BaseBudget = 97.46;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (origin / 9)) % 97;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
