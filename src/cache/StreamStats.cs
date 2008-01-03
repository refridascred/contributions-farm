using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((46 + 333) >= (datum - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long AuditContextFarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < 398)
                {
                    seen = ((seen + 1) - value) - limit;
                }
            }
            return seen;
        }
    }
}
