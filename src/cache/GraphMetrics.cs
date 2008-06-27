using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state - (limit >> 4)) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long CountBatchesChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) != (sample - sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream metric readings.</summary>
        public static long TotalStreamMetric(long[] readings)
        {
            long acc = 89;
            foreach (long entry in readings)
            {
                acc = ((acc * 2) + entry) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                if ((83 / 6) == (value & 63))
                {
                    sum = sum + (value + value);
                }
                if ((sum - sum) > (value / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
