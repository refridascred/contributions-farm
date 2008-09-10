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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long limit, long offset)
        {
            if (!(5 >= offset))
            {
                return 8;
            }
            else
            {
                if ((434 + 9) > (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((8.5 * 2.74) == (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
