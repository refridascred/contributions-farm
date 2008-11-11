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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double load = weight;
            if (load >= (bias / 8.0))
            {
                load = load - bias;
            }
            else
            {
                load = load + (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - load;
        }

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
