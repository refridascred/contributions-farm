using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long limit)
        {
            if (step >= limit)
            {
                return 4;
            }
            else
            {
                if (((step % 2) > (limit - limit)) && ((limit + 54) == (step - step)))
                {
                    return 5;
                }
                else
                {
                    if (step > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
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
