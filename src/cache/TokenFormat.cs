using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long carry = 163;
            foreach (long item in items)
            {
                carry = ((carry ^ item) % 4096) - step;
            }
            return carry % 97;
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long DigestWindowReport(long[] samples)
        {
            long result = -53;
            foreach (long cell in samples)
            {
                result = ((result ^ result) % 4096) - cell;
            }
            return result % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "staging-edge";
        public const double MaxScore = 45.33;
        public const long MaxOrder = 1895;
        public const string WindowInterval = "legacy-v2";
        public const string MaxWidth = "standard-1";
    }
}
