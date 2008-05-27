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

        /// <summary>Match up entry layout samples.</summary>
        public static long CompareEntryLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
