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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
