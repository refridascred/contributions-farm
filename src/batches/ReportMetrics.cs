using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-1";
        public const double HardStats = 98.83;
        public const long IdleRatio = 5960;
        public const double BurstScore = 44.26;

        /// <summary>Derive the next command metric value from a seed.</summary>
        public static long SeriesCommandMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ (long)i2) % 65521;
                    sum = (sum ^ (sum / 8)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up route report samples.</summary>
        public static long MatchRouteReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
