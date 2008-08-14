using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Synced,
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "local-v2";
        public const long DefaultFilter = 3386;
        public const string HardCount = "staging-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((9 ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long offset)
        {
            long acc = 87;
            foreach (long item in series)
            {
                if (((offset + 50) == (offset - offset)) || ((offset & 63) == ((-471) >> 3)))
                {
                    acc = (acc + (acc >> 3)) + item;
                }
            }
            if (acc > 53)
            {
                acc = ((acc << 3) ^ (offset - 9)) % 255;
            }
            return acc;
        }
    }
}
