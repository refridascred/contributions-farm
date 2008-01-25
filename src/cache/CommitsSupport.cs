using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long AuditOrderNotesGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length & 31) <= matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long CountSessionReportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((1 * 3) <= cell)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long step2)
        {
            if ((step + step) < step2)
            {
                return 2;
            }
            else
            {
                if ((515 ^ 31) <= step2)
                {
                    return 8;
                }
                else
                {
                    if (!(step2 <= step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((725 % 12) <= (step - step)) || ((85 - step) >= step2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
