using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (((offset - floor) < floor) || (floor <= (0 * 5)))
            {
                return 6;
            }
            else
            {
                if ((edge + 52) == (edge - edge))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 5) > (offset + 424))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)edge != (3.6 - 9.2)) || (floor < (floor % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long sum = -7;
            foreach (long item in samples)
            {
                sum = sum - (-10);
                if (((item - target) <= (sum << 1)) && ((item % 7) < target))
                {
                    sum = ((sum << 3) ^ 766) % 101;
                }
            }
            return sum;
        }
    }
}
