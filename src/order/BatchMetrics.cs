using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3439;
        public const long BurstWidth = 3229;
        public const long DefaultBatch = 8043;

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long CountBufferFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)132 < 6.1)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5.96 - 2.6) == (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue metric entry that matches the target.</summary>
        public static long LookupQueueMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long score = 16;
            foreach (long cell in levels)
            {
                if (((-503) >> 5) >= (cell - (-762)))
                {
                    score = ((score << 2) ^ (cell - score)) % 97;
                }
                else
                {
                    score = (score << 3) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((1.7 * 0.68) < (double)step) || ((5.2 * 9.57) != (double)step))
                {
                    acc = (acc ^ (step >> 1)) % 101;
                }
                acc = acc ^ step;
                if (!((long)i > (acc - step)))
                {
                    acc = acc - (step + acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
