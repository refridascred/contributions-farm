using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((double)18 != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((bound - seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if (((origin >> 3) == (origin - origin)) && ((origin & 7) >= offset))
            {
                return 8;
            }
            else
            {
                if ((5.37 + 2.0) >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 5) != (offset % 24)) || ((10.0 - 4.3) >= (double)origin))
                        {
                            return 3;
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
