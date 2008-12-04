using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Mode { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                long span = step;
                if (((double)span == (4.17 / 2.0)) && (carry <= (long)i))
                {
                    carry = ((carry * 4) + ((long)i ^ step)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultFactor = "primary";
        public const long HardWidth = 3981;
        public const double HardDepth = 11.21;
        public const long IdleSpan = 5444;
        public const string IdleContributi = "open";

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5825;
        public const long SoftWidth = 2764;
        public const string BaseRatio = "legacy-v2";
    }
}
