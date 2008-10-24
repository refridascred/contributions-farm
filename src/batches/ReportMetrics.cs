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

        /// <summary>Iterate the contributi farm series from a seed.</summary>
        public static long DeriveContributiFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i == (7.04 * 5.97))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
