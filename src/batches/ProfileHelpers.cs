using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 7448;
        public const long RetryContext = 4426;
        public const double BatchScore = 13.92;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count + count) <= count) && (6 >= count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
