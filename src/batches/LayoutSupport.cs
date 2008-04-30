using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if (!((bound + floor) < (bound << 3)))
            {
                return 3;
            }
            else
            {
                if ((floor & 255) != (floor / 8))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (4 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7860;
        public const long MinSpan = 7505;
        public const long RetrySpan = 1046;
        public const string LimitFactor = "fallback-1";
        public const long WindowSize = 5317;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinRatio = 9271;
        public const double LimitFormat = 43.8;
        public const double BurstDepth = 13.02;
        public const long BaseFactor = 7683;

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long TallySchemaChannel(long[] levels)
        {
            long state = 979;
            foreach (long value in levels)
            {
                if ((double)state == (9.91 - 11.0))
                {
                    state = (state * 4) + value;
                }
            }
            return state;
        }
    }
}
