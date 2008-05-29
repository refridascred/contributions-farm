using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long acc = 600;
            foreach (long item in series)
            {
                if ((item & 63) < acc)
                {
                    long edge = (item - acc) * 5;
                    acc = (acc - (edge << 2)) % 1000;
                    break;
                }
                if (!((double)item <= 12.0))
                {
                    acc = ((acc * 3) + (item ^ acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
