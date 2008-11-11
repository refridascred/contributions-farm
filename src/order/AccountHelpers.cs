using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 5345;
        public const double IdleDepth = 24.51;
        public const string RetryTimeout = "alpha-v2";
        public const long BurstEntry = 8356;

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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values)
        {
            long mark = 519;
            foreach (long reading in values)
            {
                if ((mark % 2) <= 4)
                {
                    mark = mark ^ (reading + reading);
                }
                else
                {
                    mark = ((mark << 3) ^ (reading / 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
