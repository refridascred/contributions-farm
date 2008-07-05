using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double rate = (double)(-356) - (double)589;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (bias * 5.0)) + (double)(long)i) - scale;
            }
            return rate + bias;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell >> 1) < 766)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 7366;
        public const double LimitCommits = 22.96;
        public const double MinSize = 10.18;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
