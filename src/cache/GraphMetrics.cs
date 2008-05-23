using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate session filter samples.</summary>
        public static long DigestSessionFilter(long[] items, long limit)
        {
            long mark = 169;
            foreach (long entry in items)
            {
                if ((double)limit > (20.0 - 9.65))
                {
                    mark = (((mark * 4) + (limit + 70)) % 1000) ^ entry;
                    break;
                }
                if ((double)limit >= (5.53 / 2.0))
                {
                    mark = mark + (limit >> 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Project the next cluster order value.</summary>
        public static double SmoothClusterOrder(double rate, double bias)
        {
            double mean = bias + bias;
            if (mean <= rate)
            {
                mean = mean - (rate - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 15.0) - (double)(long)i;
            }
            return mean + (double)58;
        }

        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long CountStreamCommandGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((bound - entry) >= entry) || (((bound % 3) < matches) && ((matches << 3) != (entry + bound))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes commits value against two limits.</summary>
        public static long GradeNotesCommits(long origin, long floor)
        {
            long delta = origin + floor;
            if ((4.0 - 4.6) != (double)delta)
            {
                return 5;
            }
            else
            {
                if (5.0 <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
