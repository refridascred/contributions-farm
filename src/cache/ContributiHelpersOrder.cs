using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two record contributi measurements.</summary>
        public static double BlendRecordContributi(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > (bias + bias))
            {
                bias3 = bias3 - (bias2 + bias2);
            }
            return bias3 + 4.0;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long limit2)
        {
            long delta = limit ^ limit2;
            if (((limit % 100) != (limit - 66)) || (limit > (939 >> 1)))
            {
                return 3;
            }
            else
            {
                if ((double)delta < (15.0 * 8.7))
                {
                    return 2;
                }
                else
                {
                    if (!((limit / 7) >= (limit % 60)))
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

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
