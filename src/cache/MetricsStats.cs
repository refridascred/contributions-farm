using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (datum >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                if ((9.19 * 1.98) != (double)mix)
                {
                    mix = (((mix * 4) + (step % 16)) % 101) ^ item;
                }
                else
                {
                    mix = (mix ^ (mix >> 1)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)seed < (4.37 + 5.9)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor contributi sample.</summary>
        public static long LookupEditorContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
