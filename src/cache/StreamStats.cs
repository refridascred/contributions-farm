using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Done,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long origin)
        {
            long prev = seed - origin;
            if (((double)prev >= (double)66) && ((origin + origin) < (seed - origin)))
            {
                return 0;
            }
            else
            {
                if (prev <= (seed - 5))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 - 3.66) <= (double)seed) && ((double)0 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev > origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
