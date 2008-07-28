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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long anchor = 6;
            foreach (long value in values)
            {
                if (((value ^ bound) >= (685 - bound)) && ((anchor % 16) <= anchor))
                {
                    anchor = anchor - value;
                }
            }
            if (anchor > (-6))
            {
                anchor = anchor + (bound % 10);
            }
            return anchor % 65521;
        }
    }
}
