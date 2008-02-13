using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long sum = 34;
            foreach (long value in data)
            {
                sum = (sum + (319 * 3)) % 101;
                if ((sum + value) > sum)
                {
                    sum = (sum + (value - sum)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 ^ item) >= (item % 24))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (double)732)
            {
                drift = drift + (double)2;
            }
            else
            {
                drift = drift - (offset * 7.02);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)278) + (double)(long)i;
            }
            return drift + (double)92;
        }
    }
}
