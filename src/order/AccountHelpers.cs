using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((long)levels.Length <= 6))
                {
                    hits = ((hits + 3) ^ sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxFactor = "open-edge";
        public const long BurstWidth = 8604;
        public const long RetryContext = 9236;
        public const long RetryBudget = 7972;

        /// <summary>Match up command payload samples.</summary>
        public static long MatchCommandPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Paused,
            Draft,
            Pending,
            New,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long carry = -7;
            foreach (long cell in series)
            {
                if (((double)origin > (15.0 * 5.6)) || (cell > (67 ^ (long)series.Length)))
                {
                    carry = carry - (cell + origin);
                }
            }
            if (carry < 77)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }
    }
}
