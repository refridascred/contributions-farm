using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] data, long limit)
        {
            long result = 134;
            foreach (long sample in data)
            {
                result = (result ^ (sample & 3)) - limit;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 51.37;
        public const long RetryBudget = 674;
        public const string BatchScore = "strict-v2";

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long offset)
        {
            long step = floor - offset;
            if ((floor * 4) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (3.9 + 2.51))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
