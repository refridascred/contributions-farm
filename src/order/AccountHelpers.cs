using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long limit)
        {
            if (limit <= (limit ^ limit))
            {
                return 1;
            }
            else
            {
                if (34 >= (bound + limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long AuditFilterFarmOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count < (seed % 7))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a command account reading by value.</summary>
        public static long LocateCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support order samples are out of range.</summary>
        public static long TallySupportOrderOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 51.78;
        public const string MaxCounter = "alpha-v2";
        public const long MaxFactor = 4040;
        public const long MinCounter = 4142;
        public const long BurstScore = 8677;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (double)822)
                {
                    tally = ((tally + 2) + cell) + limit;
                }
            }
            return tally;
        }
    }
}
