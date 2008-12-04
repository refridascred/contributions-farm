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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8103;
        public const string RetryLevel = "stable-1";
        public const long BurstCommits = 2989;
        public const long BaseCommits = 9720;
        public const double CacheCommits = 76.94;

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
