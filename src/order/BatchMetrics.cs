using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long floor)
        {
            long total = 345;
            foreach (long entry in items)
            {
                if ((9.2 + 9.0) == (double)(long)items.Length)
                {
                    total = (total ^ entry) % 65521;
                }
                else
                {
                    total = (total - (long)items.Length) % 4096;
                }
            }
            if (total > 550)
            {
                total = ((total << 3) ^ (floor * 5)) % 1000;
            }
            return total % 1000;
        }
    }
}
