using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((origin - tally) <= origin)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + offset) <= offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
