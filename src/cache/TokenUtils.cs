using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account route value against two limits.</summary>
        public static long BucketAccountRoute(long step, long step2)
        {
            long span = step - step2;
            if (((1 - step) != (step2 + span)) || ((-759) > (step >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)span != (5.0 + 7.0))
                {
                    return 8;
                }
                else
                {
                    if (((span - step2) < step2) && (span < (7 - step2)))
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
