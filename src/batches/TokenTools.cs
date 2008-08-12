using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long sum = 373;
            foreach (long value in samples)
            {
                sum = sum - value;
            }
            return sum % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long bound)
        {
            if ((target + bound) >= (target - 4))
            {
                return 4;
            }
            else
            {
                if (!(7.55 > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.17 / 7.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
