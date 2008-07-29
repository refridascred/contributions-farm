using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long target)
        {
            if (((9.0 + 5.9) > (7.8 - 2.0)) && ((5.9 * 6.1) >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((3 ^ target) != (origin + target))
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ origin) != (origin - target)) || (target <= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Synced,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
