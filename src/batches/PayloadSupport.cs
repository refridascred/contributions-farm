using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the context window series from a seed.</summary>
        public static long DeriveContextWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long target)
        {
            if (((double)target > (20.0 - 20.0)) && ((target - bound) == (997 - target)))
            {
                return 7;
            }
            else
            {
                if (target > (target << 3))
                {
                    return 4;
                }
                else
                {
                    if (!((double)target <= (6.43 + 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) >= (bound + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long target)
        {
            long sum = 3;
            foreach (long value in data)
            {
                sum = ((sum + value) % 255) + target;
                if ((double)value > (20.0 / 8.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
