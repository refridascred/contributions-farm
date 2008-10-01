using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if (sample <= 54)
                {
                    sum = ((sum << 2) ^ (sum & 1)) % 1000;
                }
            }
            if (sum < 949)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Accumulate format cluster samples.</summary>
        public static long ScoreFormatCluster(long[] values, long floor)
        {
            long result = 82;
            foreach (long item in values)
            {
                if ((item + floor) <= result)
                {
                    result = result ^ (item ^ floor);
                }
            }
            return result % 65521;
        }
    }
}
