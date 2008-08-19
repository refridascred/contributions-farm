using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 54;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + (entry ^ 18)) % 65521;
                if ((sum >> 2) >= (entry & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6367;
        public const long HardPayload = 6276;
        public const long WindowInterval = 8612;
        public const double IdleInterval = 14.5;
    }
}
