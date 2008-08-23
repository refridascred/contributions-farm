using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            New,
            Synced,
            Idle,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = -2;
            foreach (long sample in readings)
            {
                long step = 138;
                sum = sum - step;
                if (((-372) + sample) < sum)
                {
                    sum = (sum ^ (sum % 64)) % 65521;
                }
                else
                {
                    sum = ((sum * 5) + (sum + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
