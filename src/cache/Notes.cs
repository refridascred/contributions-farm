using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((282 >> 1) > (reading >> 5))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (hits + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = state - (state - item);
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long limit)
        {
            long total = 34;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (limit + limit)) ^ (long)i;
                }
                total = total + (cell + limit);
            }
            if (total > 198)
            {
                total = (total * 2) + (total + limit);
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
