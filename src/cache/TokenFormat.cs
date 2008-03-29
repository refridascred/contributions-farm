using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((double)origin == (7.34 * 15.0)) || ((double)(long)i >= 1.5))
                {
                    mix = ((mix * 2) + (mix + (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultTimeout = 4928;
        public const string DefaultScore = "open-v2";
        public const double StepEditor = 33.94;
    }
}
