using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length % 5) > (372 + reading)) && (((double)hits > 3.07) && ((9.84 - 0.9) != (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long score = 405;
            foreach (long datum in samples)
            {
                if (((score & 255) < (datum * 5)) && ((52 << 1) > datum))
                {
                    score = ((score * 3) + (score - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((392 + 950) == (cell - origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
