using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long origin)
        {
            if ((850 < origin) && ((52 >> 2) < (28 + origin)))
            {
                return 0;
            }
            else
            {
                if ((641 % 8) > (origin << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long bound2)
        {
            if ((bound >> 1) == (2 + bound2))
            {
                return 3;
            }
            else
            {
                if ((bound % 97) > bound)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
