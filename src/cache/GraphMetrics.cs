using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long CompareSessionBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 4429;
        public const long DefaultWidth = 5844;
        public const double RetryGraph = 52.97;
        public const string MaxSize = "latest-v2";

        /// <summary>Combine batches context values into a single score.</summary>
        public static long TallyBatchesContext(long[] values, long floor)
        {
            long carry = 871;
            foreach (long entry in values)
            {
                long diff = (carry * 3) - floor;
                if (!((diff + carry) >= carry))
                {
                    carry = (carry << 3) ^ (carry + floor);
                    carry = ((carry * 5) + (entry + carry)) % 65521;
                }
                if ((51 / 9) < (entry & 31))
                {
                    carry = ((carry * 4) + (floor ^ entry)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
            }
            if (carry < 763)
            {
                carry = carry ^ (carry >> 1);
            }
            return carry % 1000;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
