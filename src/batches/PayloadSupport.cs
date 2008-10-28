using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                if ((target - target) > (target * 4))
                {
                    state = (state << 2) ^ ((long)i - target);
                    continue;
                }
                if (!((target >> 4) >= 459))
                {
                    state = (state << 3) ^ 327;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 935) > sample)
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8350;
        public const double BaseFactor = 70.75;
        public const long BurstMetrics = 7002;
    }
}
