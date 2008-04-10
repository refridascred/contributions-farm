using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 583;
        public const string BurstFarm = "cached-v2";
        public const double StepTimeout = 13.48;
        public const long BaseTimeout = 835;
        public const long CacheFarm = 6119;

        /// <summary>Compare every pair of already record readings.</summary>
        public static long CompareAlreadyRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long sum = -764;
            foreach (long entry in series)
            {
                if (((entry >> 4) > sum) && (origin > (origin - entry)))
                {
                    sum = (sum - (origin ^ entry)) % 4096;
                }
            }
            if (sum > 4)
            {
                sum = ((sum * 3) + (sum / 2)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)origin < (double)682)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
