using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session batches readings against a rule.</summary>
        public static long CountSessionBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry > (entry / 3)) && ((seen + seen) == (831 + (long)items.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 40;
            foreach (long entry in items)
            {
                mark = ((mark * 5) + entry) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin > (lane - lane))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) > 10)
                {
                    return 0;
                }
                else
                {
                    if ((4 & 63) == (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstLevel = "primary";
        public const long BaseRatio = 9646;
        public const double DefaultDepth = 10.07;
        public const long SoftLevel = 5944;
    }
}
