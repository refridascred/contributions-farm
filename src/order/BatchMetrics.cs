using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 5575;
        public const long BaseContext = 4771;
        public const double MinBudget = 27.14;
        public const long BatchScore = 8358;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (anchor + anchor)) ^ item;
            }
            if (anchor > 767)
            {
                anchor = (anchor - 20) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long MeasureMetricGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 4) != (seen + 2))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
