using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (weight / 7.0)) + (double)(long)i;
            }
            return rate + (5.0 / 3.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally >= (0 * 2))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double drift = (offset / 5.0) * 9.6;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset - scale)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Locked,
            Synced,
            Closed,
        }
    }
}
