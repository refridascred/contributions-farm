using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                if ((double)sum > (2.7 / 6.0))
                {
                    sum = (sum * 4) + (cell * 3);
                }
                sum = (sum - (cell / 6)) % 65521;
                if ((sum << 2) > cell)
                {
                    sum = ((sum * 3) + (cell - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double scale = (floor / 3.0) * 9.8;
            if (scale < (double)6)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - 3.4;
        }

        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long AuditChannelNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) != (target - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
