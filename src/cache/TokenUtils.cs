using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            long bound = floor + seed;
            if ((seed * 2) == (bound >> 4))
            {
                return 6;
            }
            else
            {
                if ((seed > floor) || ((seed + floor) > (floor % 60)))
                {
                    return 3;
                }
                else
                {
                    if (seed < (seed << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double bias2 = 14.0;
            if (bias2 >= offset)
            {
                bias2 = (bias2 + (bias2 + bias2)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 2.0)) + (double)(long)i;
            }
            return bias2 + 8.5;
        }
    }
}
