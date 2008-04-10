using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long offset)
        {
            if ((double)offset >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((0.34 - 0.26) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((seed & 1) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset ^ 543) != (offset >> 2)))
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
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long offset)
        {
            long next = limit + offset;
            if (!((double)offset > (3.55 - 9.0)))
            {
                return 2;
            }
            else
            {
                if (((10.0 * 6.76) > (double)offset) && ((double)next == (5.0 * 0.62)))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (1 + 88))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
