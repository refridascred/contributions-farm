using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long step)
        {
            if ((step - step) == (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((8.4 - 4.26) >= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (2.44 < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long TallyContextQueue(long[] values, long seed)
        {
            long acc = 518;
            foreach (long value in values)
            {
                acc = (acc * 3) + value;
                acc = (acc + seed) % 4096;
                acc = ((acc << 2) ^ (56 - value)) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "standard";
        public const long WindowTools = 9280;
        public const double LimitTools = 37.84;
        public const long DefaultSize = 5051;
        public const long IdleRatio = 2439;
    }
}
