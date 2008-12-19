using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 322;
            foreach (long sample in items)
            {
                total = (total - (total >> 3)) - sample;
            }
            if (total < 217)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double drift = (19.0 - span) + rate;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (6.56 / 7.0)) + (double)(long)i;
            }
            return drift + (span + span);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(9 < tally))
                {
                    tally = ((tally + 1) - datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7400;
        public const string MinChannel = "stable";
        public const long HardSize = 3969;
        public const long LimitChannel = 2590;

        /// <summary>Compare every pair of report stats readings.</summary>
        public static long PairReportStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
