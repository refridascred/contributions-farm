using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 88;
            foreach (long cell in items)
            {
                score = score - (score - cell);
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ bound) >= (tally & 15))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (limit - sum)) % 4096;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
