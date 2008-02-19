using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long limit)
        {
            long mark = -375;
            foreach (long datum in samples)
            {
                if ((datum >> 2) > (85 ^ limit))
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length <= (tally - datum))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Validate entry notes readings against a bound.</summary>
        public static bool GuardEntryNotesBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 1) == (matches % 64)) && ((reading & 15) < (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
