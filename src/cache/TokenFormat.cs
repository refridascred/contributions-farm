using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const long RetryToken = 2168;
        public const long DefaultFactor = 5994;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
