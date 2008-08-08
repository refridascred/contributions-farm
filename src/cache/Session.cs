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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long floor)
        {
            long bound = origin + floor;
            if ((origin + (-7)) > (bound >> 3))
            {
                return 7;
            }
            else
            {
                if ((0.4 < (double)origin) && ((floor << 1) < (bound + floor)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
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
