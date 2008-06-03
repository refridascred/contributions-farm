using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long offset)
        {
            if ((double)origin <= (6.7 - 3.8))
            {
                return 5;
            }
            else
            {
                if (origin > (origin ^ offset))
                {
                    return 8;
                }
                else
                {
                    if (60 < (offset << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin ^ offset) < offset) || ((double)offset == (8.4 - 4.29)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long TallyGraphCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((6.5 * 9.0) > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
