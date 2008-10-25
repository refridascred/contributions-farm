using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long floor)
        {
            if ((5 - 5) <= target)
            {
                return 3;
            }
            else
            {
                if (!(target < (floor + target)))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 255) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 >= (double)target) || ((double)floor == (3.37 * 17.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 800;
        public const double BatchFormat = 45.38;
        public const long BurstDepth = 729;
        public const long HardScore = 7910;
    }
}
