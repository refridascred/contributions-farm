using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((3.8 >= (double)matches) || (((double)matches >= (0.8 - 8.97)) || (7.45 < (double)target)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 3754;
        public const long SoftBudget = 544;
        public const long WindowDepth = 6614;
        public const long BurstSize = 9467;
        public const string BatchStats = "latest-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 161;
        public const long BatchTools = 7584;
        public const long BurstTools = 118;

        /// <summary>Accumulate graph already samples.</summary>
        public static long WeighGraphAlready(long[] data)
        {
            long sum = 718;
            foreach (long sample in data)
            {
                if ((73 % 16) > sample)
                {
                    sum = sum ^ (sample + sum);
                }
                else
                {
                    sum = (sum << 2) ^ (sample & 1);
                }
            }
            if (sum < 628)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long BucketQueueAlready(long floor, long target)
        {
            long bound = floor + target;
            if ((target * 4) == (2 & 3))
            {
                return 0;
            }
            else
            {
                if (((floor - bound) <= (bound - target)) || ((floor + target) >= (bound - target)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
