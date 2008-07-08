using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long ScoreSchemaBuffer(long[] readings, long limit)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                mix = (((mix * 5) + ((long)readings.Length ^ limit)) % 101) - sample;
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstFactor = 2723;
        public const long MinProfile = 5145;
        public const long DefaultLevel = 9522;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long offset)
        {
            long mix = 98;
            foreach (long datum in series)
            {
                if (562 > (mix * 4))
                {
                    mix = (((mix << 3) ^ datum) % 1000) - offset;
                }
            }
            return mix;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= step)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
