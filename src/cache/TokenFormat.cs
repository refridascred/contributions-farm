using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long seed)
        {
            if (!((seed + seed) <= (seed << 1)))
            {
                return 1;
            }
            else
            {
                if (((47 << 2) <= (seed + bound)) && ((double)bound >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((0.95 - 7.8) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long origin)
        {
            if (origin > (origin - 69))
            {
                return 5;
            }
            else
            {
                if (!((3.62 / 3.0) == (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin < (step >> 3)) && ((8.0 - 8.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
