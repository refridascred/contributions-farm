using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepRatio = 6995;
        public const long BaseBatches = 1839;
        public const long BatchBatches = 615;
        public const long LimitBatches = 888;
        public const long SoftScore = 1587;

        /// <summary>Iterate the notes tools series from a seed.</summary>
        public static long DeriveNotesTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((949 ^ (long)i) > (84 >> 4)))
                {
                    sum = (sum * 5) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxSpan = 81.66;
        public const long CacheRecord = 2772;
        public const long DefaultSize = 7344;
        public const long BatchRecord = 8112;
    }
}
