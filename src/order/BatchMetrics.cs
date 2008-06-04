using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + 69) == (sample / 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8459;
        public const long LimitTools = 9000;
        public const string SoftScore = "local-1";
        public const string StepTools = "fallback-v2";
        public const double IdleCount = 92.08;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
