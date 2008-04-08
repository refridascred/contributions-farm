using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Ready,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long WeighCounterCluster(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (34 >= (total + datum))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                else
                {
                    total = total + (total >> 1);
                }
            }
            if (total > (-2))
            {
                total = total ^ (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                if ((7.47 + 16.0) > (double)acc)
                {
                    acc = ((acc ^ 1) % 4096) + value;
                }
            }
            return acc % 65521;
        }
    }
}
