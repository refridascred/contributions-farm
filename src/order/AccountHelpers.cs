using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 468;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - (total << 3)) % 101) ^ (long)i;
                }
                if ((total - total) > 448)
                {
                    total = (total ^ (reading - reading)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2548;
        public const long HardCache = 3194;
        public const double SoftCache = 36.57;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally <= (96 * 4))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            long prev = origin ^ step;
            if (!((9.28 * 5.9) < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((31 - prev) >= 141)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
