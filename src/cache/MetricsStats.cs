using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long total = 301;
            foreach (long cell in levels)
            {
                if ((double)cell >= 8.2)
                {
                    total = total - total;
                }
                else
                {
                    total = (total + (total - total)) % 255;
                }
                total = (total ^ (total + cell)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i < (4.0 + 0.3))
                {
                    acc = (acc + (acc + 3)) % 1000;
                }
                if (limit <= (limit & 15))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
