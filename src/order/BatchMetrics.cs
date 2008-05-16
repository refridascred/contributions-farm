using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 5) > (long)values.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4473;
        public const double RetryBudget = 20.07;
        public const string MaxRatio = "alpha-v2";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double rate = scale;
            if (rate >= (rate * 6.3))
            {
                rate = rate + (rate - floor);
            }
            return rate - (rate * 5.8);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum & 7) >= (datum & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
