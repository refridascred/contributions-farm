using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double load = 3.0;
            if (load <= 2.57)
            {
                load = ((load + (double)7) - gain) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long target)
        {
            if ((limit * 4) >= (limit / 5))
            {
                return 0;
            }
            else
            {
                if (target > (target - 257))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (14.0 * 9.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
