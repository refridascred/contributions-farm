using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (mean / 8.0))
            {
                mean = mean + (floor / 5.0);
            }
            return mean + mean;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 118;
            foreach (long reading in readings)
            {
                if (reading >= (1 + acc))
                {
                    acc = acc + reading;
                }
            }
            if (acc < (-36))
            {
                acc = (acc + (acc ^ 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
