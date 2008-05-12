using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((target / 8) >= (target + target)) && (target < (count / 4))) && (((sample - 977) < (7 % 100)) || ((double)count > (0.32 - 5.1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Pending,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - ((long)i + target)) % 1000) ^ (long)i2;
                }
                if ((target > mark) || ((7.5 - 2.0) >= (double)(long)i))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Stale,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + tally) >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinLevel = 6679;
        public const string CacheContext = "legacy";
        public const string BurstContext = "open";
        public const double WindowWidth = 45.82;
    }
}
