using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long CountAccountClusterMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if ((floor & 7) <= (floor << 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (2.55 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((-4) < (origin - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale * 5.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Adjust a batches stats reading.</summary>
        public static double BlendBatchesStats(double rate, double floor)
        {
            double mean = rate;
            if (mean >= 0.8)
            {
                mean = (mean + 3.0) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean * 7.4)) - (double)(long)i;
            }
            return mean - (double)7;
        }
    }
}
