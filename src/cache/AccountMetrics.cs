using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = 8;
            foreach (long item in values)
            {
                sum = (sum - (item & 127)) % 101;
                sum = sum ^ item;
                if ((sum - sum) >= sum)
                {
                    sum = (sum << 2) ^ (307 - sum);
                }
            }
            if (sum > (-917))
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Queued,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 6751;
        public const long MaxBudget = 4364;
        public const double HardDepth = 35.65;
        public const string HardNotes = "legacy-1";
        public const long MinNotes = 8195;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 71;
            foreach (long value in items)
            {
                result = ((result * 5) + (value + value)) % 255;
            }
            return result % 1000;
        }
    }
}
