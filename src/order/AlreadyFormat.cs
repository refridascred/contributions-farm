using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch tools value against two limits.</summary>
        public static long SortBatchTools(long step, long bound)
        {
            if (((step ^ step) <= (step * 2)) && (bound <= (4 & 3)))
            {
                return 5;
            }
            else
            {
                if ((step + bound) == (57 & 63))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((19.0 * 18.0) > (19.0 - 3.4)) && ((hits ^ bound) == (hits << 1)))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue stats readings against a bound.</summary>
        public static bool ValidateQueueStatsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long ClassifyCounterCluster(long bound, long step)
        {
            if (bound > (-51))
            {
                return 1;
            }
            else
            {
                if (4 >= step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
