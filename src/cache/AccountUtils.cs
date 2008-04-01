using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next support cluster value.</summary>
        public static double AdjustSupportCluster(double bias, double span)
        {
            double ratio = (double)(3 << 1);
            return ((ratio + (2.0 / 4.0)) + bias) + span;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
