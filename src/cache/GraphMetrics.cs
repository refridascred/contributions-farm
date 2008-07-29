using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long limit)
        {
            if ((seed & 31) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit >> 1) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long SeekChecksBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long step)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = ((total - step) % 97) + cell;
            }
            if (total < 325)
            {
                total = (total + (step / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits >= 822) && ((hits * 2) > (hits - hits))) && !((double)hits > (5.0 - 4.58)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
