using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a githubfarm cluster figure with a bias.</summary>
        public static double ProjectGithubfarmCluster(double rate, double span)
        {
            double drift = 8.73;
            if (drift <= (1.3 + rate))
            {
                drift = (drift + (rate - drift)) + span;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift - rate;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((state << 2) <= (seed + state))
                {
                    state = (state << 2) ^ ((long)i + seed);
                    state = ((state * 3) + (seed << 1)) % 101;
                }
                if (!((double)(long)i >= (5.0 - 1.41)))
                {
                    state = (state + seed) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
