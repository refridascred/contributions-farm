using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long seed)
        {
            long total = -310;
            foreach (long item in items)
            {
                total = (total - (seed - item)) % 4096;
            }
            if (total > 505)
            {
                total = (total << 3) ^ (seed & 63);
            }
            return total % 4096;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of stream queue readings.</summary>
        public static long CompareStreamQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
