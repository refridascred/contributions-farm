using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long limit)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((0.01 / 8.0) <= (double)limit)
                {
                    total = ((total * 4) + (4 + limit)) ^ reading;
                }
            }
            if (total < 153)
            {
                total = (total * 3) + (limit & 7);
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1083;
        public const string DefaultProfile = "strict-1";
        public const long MaxSpan = 7262;
        public const long MinProfile = 6603;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta == (double)294)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 7.0) != (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta + 0) <= (delta ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Paused,
            Failed,
            Pending,
        }
    }
}
