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

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long TallyChannelFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) >= (datum + 20))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((entry - carry) <= (entry >> 1))
                {
                    carry = ((carry << 2) ^ 949) % 97;
                }
            }
            if (carry > 924)
            {
                carry = ((carry * 5) + (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
