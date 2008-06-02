using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples)
        {
            long mix = 69;
            foreach (long reading in samples)
            {
                if ((mix > (reading + mix)) || ((mix + mix) >= (mix % 24)))
                {
                    mix = ((mix << 2) ^ (long)samples.Length) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Closed,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double rate = (double)(907 >> 2);
            if (rate < rate)
            {
                rate = ((rate + (0.1 + rate)) + bias) - floor;
            }
            return rate - 1.41;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Active,
            Synced,
            Pending,
        }
    }
}
