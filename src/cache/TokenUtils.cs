using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - 42) > (limit ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) != (1 + datum))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
