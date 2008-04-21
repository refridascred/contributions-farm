using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum ^ matches) >= (datum - 87)) || ((double)matches < 7.51))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(target >= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally != (double)69)
                {
                    tally = ((tally + 3) - entry) - floor;
                }
            }
            return tally;
        }
    }
}
