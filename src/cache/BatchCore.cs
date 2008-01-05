using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long target2)
        {
            if ((double)target != (7.0 + 0.21))
            {
                return 2;
            }
            else
            {
                if (target2 > (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target2 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target <= (7.47 + 8.0)) || ((double)(-1) >= (double)target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double scale = (ratio * 16.0) + (ratio + ratio);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (ratio / 9.0)) + (double)(long)i) - floor;
            }
            return scale + 19.0;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long carry = 54;
            foreach (long entry in items)
            {
                carry = (carry - (37 ^ entry)) % 4096;
            }
            return carry % 97;
        }
    }
}
