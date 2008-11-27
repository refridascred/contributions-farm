using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long acc = 59;
            foreach (long datum in levels)
            {
                acc = (acc ^ acc) + datum;
            }
            if (acc < 5)
            {
                acc = ((acc * 2) + (bound >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
