using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if (((acc + reading) != (234 / 9)) && (acc >= (acc << 1)))
                {
                    acc = (acc - 848) + floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (acc - 5)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
