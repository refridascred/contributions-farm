using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long TallyChecksBatchesHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((count & 1) < ((-11) - reading)) || ((count * 3) > (4 / 2))))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long SeriesAlreadySchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardCount = 13.9;
        public const string WindowOrder = "legacy";
        public const long BatchOrder = 5058;
        public const long IdleOrder = 3449;
        public const long DefaultOrder = 2463;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Synced,
            Locked,
        }
    }
}
