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

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
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

        /// <summary>Project the next order githubfarm value.</summary>
        public static double BlendOrderGithubfarm(double ratio, double floor)
        {
            double bias = (double)23 * 13.0;
            if (bias <= (ratio * 3.7))
            {
                bias = bias - (floor / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (floor - ratio)) + (double)(long)i;
            }
            return bias - (ratio + floor);
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
