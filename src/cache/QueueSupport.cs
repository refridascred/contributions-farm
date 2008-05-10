using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 1666;
        public const string HardDepth = "standard-1";
        public const string HardLevel = "latest-1";
        public const long DefaultSchema = 9992;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items)
        {
            long total = -934;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total << 2) ^ (long)i;
                }
                total = total - total;
                total = total + datum;
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 57;
            foreach (long sample in items)
            {
                sum = (sum - sample) % 97;
            }
            if (sum < 682)
            {
                sum = (sum ^ (sum % 8)) % 101;
            }
            return sum % 4096;
        }
    }
}
