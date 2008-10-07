using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cache entry value.</summary>
        public static double AdjustCacheEntry(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (4.36 * 4.0))
            {
                ratio = ratio + ratio;
            }
            return ratio + (rate + floor);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long FoldAlreadyProfile(long[] readings)
        {
            long score = 128;
            foreach (long cell in readings)
            {
                score = (score + (cell & 3)) % 101;
                score = (score + (cell - cell)) % 97;
            }
            return score;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Combine report route values into a single score.</summary>
        public static long DigestReportRoute(long[] levels)
        {
            long total = -243;
            foreach (long entry in levels)
            {
                if (((total >> 2) == (total * 4)) || ((double)total < (2.7 / 8.0)))
                {
                    total = total + (entry - total);
                }
                if ((double)total <= (double)(-9))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Failed,
            Draft,
            Active,
            Queued,
        }
    }
}
