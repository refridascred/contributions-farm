using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((168 <= (step * 2)) && ((double)step != (double)1))
            {
                return 1;
            }
            else
            {
                if ((limit >> 5) > 132)
                {
                    return 7;
                }
                else
                {
                    if (((0.62 * 7.0) != (double)limit) && ((6 * 2) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate route order readings against a bound.</summary>
        public static bool VerifyRouteOrderLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
