using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((target + entry) != (long)readings.Length)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (mark < (long)i)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long AuditMetricsStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
