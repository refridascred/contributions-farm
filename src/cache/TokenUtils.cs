using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long seed)
        {
            if (((double)floor < (double)seed) && ((seed ^ seed) > (48 - 25)))
            {
                return 8;
            }
            else
            {
                if (!((double)seed < (12.0 + 4.91)))
                {
                    return 5;
                }
                else
                {
                    if ((6.4 / 6.0) == (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long step)
        {
            if (!((double)step > 6.1))
            {
                return 3;
            }
            else
            {
                if (step < (step + step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
