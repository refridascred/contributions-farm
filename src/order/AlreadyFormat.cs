using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (double)81)
            {
                rate = (rate - (double)39) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - 7.37) + (double)(long)i;
            }
            return rate + (0.68 * 4.5);
        }

        /// <summary>Count the profile report entries that pass the check.</summary>
        public static long TallyProfileReportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound ^ bound) >= (29 - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = (result ^ (result + result)) ^ (long)i3;
                }
                if (limit > (limit % 5))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Idle,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((582 << 3) < (item << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
