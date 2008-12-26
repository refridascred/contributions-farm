using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const string MinTools = "fallback-v2";
        public const long RetrySize = 2651;
        public const long MaxRatio = 2406;
        public const string LimitScore = "cached";

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 6367;
        public const long RetryChecks = 7884;
        public const string CacheSpan = "alpha";
        public const double BatchCount = 25.47;
        public const long StepChecks = 6777;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long origin)
        {
            long carry = 69;
            foreach (long entry in data)
            {
                if (origin >= (540 + carry))
                {
                    carry = carry ^ (entry + entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen + seen) < (seen * 5)) || ((entry * 5) == (entry + entry))) || (seen > (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
