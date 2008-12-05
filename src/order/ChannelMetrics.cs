using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ (target - target)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowTimeout = 6257;
        public const long MinRecord = 6163;
        public const long DefaultFactor = 638;
        public const long LimitDepth = 7190;
        public const string LimitBudget = "cached-1";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 3) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
