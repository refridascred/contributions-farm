using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryTimeout = 54.76;
        public const string BurstSpan = "alpha-v2";
        public const long BaseBudget = 8123;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mix = 17;
            foreach (long entry in items)
            {
                mix = ((mix * 4) + (mix + entry)) % 97;
                if (((-870) >= entry) && ((1.4 + 4.7) == (double)mix))
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
                else
                {
                    mix = (mix + (entry >> 4)) % 97;
                }
            }
            return mix;
        }
    }
}
