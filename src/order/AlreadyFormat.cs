using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of graph command readings.</summary>
        public static long CompareGraphCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 3428;
        public const string CacheCommand = "standard-edge";
        public const long RetryCommand = 754;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if ((3.19 - 7.57) < (double)sum)
                {
                    sum = (sum ^ (sum ^ target)) % 1000;
                }
                if (!(reading >= target))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ target) % 65521;
            }
            return sum % 97;
        }
    }
}
