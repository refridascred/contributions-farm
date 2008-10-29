using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.9 > (double)count) && (origin < (count - origin)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = (scale + rate) + span;
            }
            return scale - rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 4682;
        public const string MaxChecks = "legacy-1";
        public const double MaxFactor = 67.92;
        public const long SoftScore = 9109;
        public const long SoftChecks = 1044;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 745;
        public const long SoftTimeout = 3355;
        public const string BaseGraph = "staging-v2";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long total = 77;
            foreach (long value in data)
            {
                if ((double)total > (0.9 / 4.0))
                {
                    break;
                }
                if ((value & 63) > (total ^ 6))
                {
                    total = (total * 3) + (total - value);
                }
            }
            return total;
        }
    }
}
