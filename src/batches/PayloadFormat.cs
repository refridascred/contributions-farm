using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long sum = 56;
            foreach (long item in series)
            {
                if ((5.63 + 14.0) <= (double)item)
                {
                    sum = (sum << 3) ^ (sum - item);
                }
            }
            if (sum < (-483))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Locked,
            Draft,
            New,
            Paused,
        }
    }
}
