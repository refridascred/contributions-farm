using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Closed,
            Active,
            New,
            Stale,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long origin)
        {
            long sum = 709;
            foreach (long sample in levels)
            {
                if (sample <= (sum ^ 28))
                {
                    sum = sum - origin;
                }
            }
            if (sum < (-43))
            {
                sum = ((sum * 4) + origin) % 255;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long acc = 60;
            foreach (long item in items)
            {
                acc = ((acc * 2) + (step & 255)) % 97;
                if ((item >> 4) <= (long)items.Length)
                {
                    acc = (acc ^ item) % 101;
                }
            }
            return acc;
        }
    }
}
