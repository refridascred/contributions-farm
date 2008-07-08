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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((1.0 * 1.11) >= (9.24 - 2.4))
                {
                    total = ((total * 3) + (floor + floor)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ 48) % 97;
                }
                total = (total ^ ((long)i & 15)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
