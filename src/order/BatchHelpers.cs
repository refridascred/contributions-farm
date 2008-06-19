using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long origin)
        {
            long slot = limit ^ origin;
            if (!((origin + slot) >= (slot + slot)))
            {
                return 3;
            }
            else
            {
                if ((limit ^ slot) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((slot / 8) >= (9 & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.7 + 8.92) == (double)origin))
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

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
