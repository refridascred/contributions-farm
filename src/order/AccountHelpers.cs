using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target - target2;
            if ((step * 2) != (target2 + step))
            {
                return 6;
            }
            else
            {
                if ((target + target2) <= 74)
                {
                    return 0;
                }
                else
                {
                    if (!(195 < (target ^ 54)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
