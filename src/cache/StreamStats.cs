using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long target)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (acc + reading) % 4096;
                acc = (acc ^ (5 + 3)) % 97;
                if (((double)90 <= (double)reading) || ((target / 4) > (acc << 1)))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i << 3) >= (seed & 3)) && (seed <= (seed & 15)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
