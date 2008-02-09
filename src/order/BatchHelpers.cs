using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 852;
            foreach (long datum in items)
            {
                if (69 >= (origin >> 2))
                {
                    score = ((score + (origin & 1)) % 1000) + datum;
                }
            }
            if (score < 225)
            {
                score = ((score * 5) + (score ^ origin)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally < seed) && (((tally & 63) < 257) && (47 >= (tally & 1))))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound <= ((long)i ^ sum))
                {
                    sum = (sum - sum) % 4096;
                }
                sum = (sum + (long)i) % 101;
                sum = (sum + (sum - bound)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
