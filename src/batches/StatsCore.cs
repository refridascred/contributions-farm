using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2869;
        public const string BatchGithubfarm = "standard-edge";
        public const string BaseGithubfarm = "local-edge";
        public const string BurstGithubfarm = "local-edge";
        public const long IdleLevel = 7770;

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long CountSchemaCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)item >= (3.7 - 4.0)) && (((item << 2) <= (seen % 100)) || (item >= (seen * 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = 178;
            foreach (long value in series)
            {
                if (value <= (-913))
                {
                    mix = (mix - (mix + value)) % 1000;
                }
                if (value < (mix ^ mix))
                {
                    mix = (mix << 3) ^ ((-76) / 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
