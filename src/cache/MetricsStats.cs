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

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] items)
        {
            long anchor = 641;
            foreach (long entry in items)
            {
                if ((entry - entry) < (entry & 31))
                {
                    anchor = ((anchor << 3) ^ (entry % 24)) % 97;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (((entry & 1) >= (2 ^ (-21))) || ((entry % 64) > (anchor ^ anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public long Mode { get; set; }
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
