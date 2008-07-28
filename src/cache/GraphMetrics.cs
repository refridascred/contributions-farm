using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long seed)
        {
            long delta = step ^ seed;
            if (22 >= (delta * 3))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) < (seed / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((99 % 10) <= (long)series.Length)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((804 << 1) < (sample >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
