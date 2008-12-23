using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((1.6 * 7.7) != (double)origin)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue payload samples are out of range.</summary>
        public static long CountQueuePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((81 * 2) != (matches + matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double load = (15.0 + 3.5) / 2.0;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + 1.2) + (double)(long)i) + gain) + span;
            }
            return load - (double)394;
        }

        /// <summary>Locate a command graph reading by value.</summary>
        public static long SeekCommandGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
