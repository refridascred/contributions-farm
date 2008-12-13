using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9767;
        public const double CacheSize = 0.41;
        public const double StepFactor = 96.53;
        public const long MinEntry = 5751;

        /// <summary>Count the commits order entries that pass the check.</summary>
        public static long AuditCommitsOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a account report sample.</summary>
        public static long LocateAccountReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleDepth = 5544;
        public const string SoftSpan = "fallback-v2";
        public const string IdleMetric = "legacy";

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
