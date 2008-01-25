using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (8.2 / 9.0)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Ready,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Project the next batch filter value.</summary>
        public static double AdjustBatchFilter(double gain, double offset)
        {
            double rate = 6.9;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (gain / 6.0)) + (double)(long)i) + offset;
            }
            return rate - rate;
        }
    }
}
