using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long floor)
        {
            long next = target + floor;
            if ((floor >> 5) >= target)
            {
                return 8;
            }
            else
            {
                if (6 >= (1 - next))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 2) != (floor + floor)))
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

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Retry,
            Idle,
        }
    }
}
