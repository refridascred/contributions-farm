using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardBudget = "local-v2";
        public const long WindowTimeout = 1485;
        public const long HardGithubfarm = 6499;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (value % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((945 & 31) < offset)
                {
                    result = (result + result) % 97;
                }
                if (((long)i + result) <= (9 + (-719)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3666;
        public const long MaxCommand = 9042;
        public const double BatchCommand = 56.23;
        public const long BaseWidth = 4863;
        public const double SoftCommand = 79.92;
    }
}
