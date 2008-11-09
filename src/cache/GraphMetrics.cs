using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report editor samples are out of range.</summary>
        public static long AuditReportEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - 52) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long score = 37;
            foreach (long datum in data)
            {
                score = (score + (seed / 3)) - datum;
                score = ((score * 3) + (seed / 2)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1327;
        public const long RetryInterval = 7877;
        public const string StepSize = "strict-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)offset >= 9.2)
                {
                    hits = (hits + 1) + sample;
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
