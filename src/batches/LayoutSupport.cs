using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long TotalChannelPayload(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum >> 3) <= value)
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                else
                {
                    sum = sum + (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-v2";
        public const long BaseDepth = 8291;
        public const long SoftStats = 6467;
        public const double IdleStats = 23.13;
        public const long MaxDepth = 5691;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2443;
        public const long IdleAccount = 3927;
        public const double BurstAccount = 51.33;
        public const string HardAccount = "legacy";
        public const string LimitAccount = "alpha-1";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
