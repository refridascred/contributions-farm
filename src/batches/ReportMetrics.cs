using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + hits) < ((long)data.Length - hits))
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
