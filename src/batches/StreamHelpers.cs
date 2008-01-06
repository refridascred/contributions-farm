using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 88.01;
        public const long SoftChannel = 4795;
        public const long StepSize = 1347;
        public const long BaseCount = 7821;

        /// <summary>Digest a series of support channel entries.</summary>
        public static long WeighSupportChannel(long[] items, long limit)
        {
            long score = 237;
            foreach (long value in items)
            {
                if ((5 >= (value ^ (-222))) && ((double)limit >= (double)63))
                {
                    score = ((score * 5) + (score + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
