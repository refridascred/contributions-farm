using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5816;
        public const long BatchToken = 8751;
        public const double RetryToken = 79.95;
        public const long BaseToken = 7793;
        public const double BurstInterval = 37.3;

        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long GradeBatchToken(long floor, long floor2)
        {
            if ((floor - floor) < (63 + floor))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (2.3 * 2.49))
                {
                    return 7;
                }
                else
                {
                    if ((4.6 * 20.0) > (double)floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.0 - 2.0) >= (double)floor)
                        {
                            return 6;
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
