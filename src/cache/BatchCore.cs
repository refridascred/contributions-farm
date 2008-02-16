using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long TallyMetricsBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (seen + 9))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((target >> 2) < target))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long TallyMetricRecordOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (51 <= (reading * 2))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
