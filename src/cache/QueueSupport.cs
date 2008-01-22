using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultScore = "open";
        public const long MinFactor = 5485;
        public const string HardAccount = "staging-edge";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score + score) - item;
            }
            if (score < 989)
            {
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }
    }
}
