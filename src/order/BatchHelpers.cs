using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < limit)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum + seed) < datum) || ((seed - 72) < (seed % 97)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
