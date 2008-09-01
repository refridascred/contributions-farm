using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long next = offset ^ floor;
            if (!((6.0 + 1.5) <= (double)offset))
            {
                return 1;
            }
            else
            {
                if ((1.25 + 5.0) < (double)next)
                {
                    return 7;
                }
                else
                {
                    if (next <= (next % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
