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

        /// <summary>Derive the next metric graph value from a seed.</summary>
        public static long IterateMetricGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 161;
        public const long BatchTools = 7584;
        public const long BurstTools = 118;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryWidth = 82.02;
        public const double IdleFactor = 92.25;
        public const double WindowInterval = 97.45;

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
