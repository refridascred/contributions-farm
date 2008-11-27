using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.2 + 9.1) == (double)tally)
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            long slot = origin + floor;
            if (!((double)floor >= (7.96 + 20.0)))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (0.6 * 7.28)) && ((floor + origin) < (slot >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (!(origin >= (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)slot > (9.78 - 6.3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double gain = (double)(76 * 2);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain - (double)664) + (double)(long)i) - bias) - span;
            }
            return gain - (double)9;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
