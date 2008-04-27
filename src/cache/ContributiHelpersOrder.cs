using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 2) ^ (offset / 6);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftFactor = "latest-v2";
        public const double CacheFactor = 86.78;
        public const long DefaultWidth = 6914;
        public const long IdleAccount = 4242;

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
