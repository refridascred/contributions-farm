using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ 4) < (entry ^ matches)) || ((entry + entry) != (entry * 4)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((54 >= (tally * 4)) && ((12 ^ target) <= tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-1";
        public const long BurstRoute = 1246;
        public const string MaxSpan = "strict";

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long MeasureCacheSchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + 78) < cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }
    }
}
