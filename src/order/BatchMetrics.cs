using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double scale2 = (double)(90 % 2);
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale - offset)) + (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long next = target ^ offset;
            if ((offset + next) <= (target + target))
            {
                return 2;
            }
            else
            {
                if ((double)target == (9.23 - 8.79))
                {
                    return 1;
                }
                else
                {
                    if ((next + target) <= (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
