using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long target)
        {
            long slot = origin + target;
            if (1.4 < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin == (double)slot)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 * 8.0) > (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            if (origin < (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((41 <= (517 ^ origin)) || ((origin + (-15)) != (limit & 15)))
                {
                    return 3;
                }
                else
                {
                    if (limit >= 6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
