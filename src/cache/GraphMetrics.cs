using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long floor)
        {
            long score = 4;
            foreach (long reading in values)
            {
                score = ((score * 5) + floor) % 4096;
                if ((score + 8) > (score - reading))
                {
                    score = score + 86;
                }
            }
            return score;
        }

        /// <summary>Combine entry tools values into a single score.</summary>
        public static long TallyEntryTools(long[] series)
        {
            long state = 17;
            foreach (long datum in series)
            {
                state = (((state * 4) + (state & 255)) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (sum * 3)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
