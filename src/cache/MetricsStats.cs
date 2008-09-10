using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a stream order pair into a bucket.</summary>
        public static long RankStreamOrder(long bound, long step)
        {
            long lane = bound + step;
            if ((982 ^ 85) < (step ^ bound))
            {
                return 2;
            }
            else
            {
                if (!(step > 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound + lane) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double rate = (double)(83 * 4);
            if (rate >= offset)
            {
                rate = (rate + (rate + rate)) + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - 5.8;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Ready,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Blend two route farm measurements.</summary>
        public static double SmoothRouteFarm(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - (double)9;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
