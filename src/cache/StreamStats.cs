using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long seed)
        {
            long diff = target ^ seed;
            if (target < (diff ^ seed))
            {
                return 7;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (1.0 * 1.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
