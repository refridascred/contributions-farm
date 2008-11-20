using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxTimeout = 26.32;
        public const long BaseStats = 1868;
        public const long LimitStats = 537;
        public const long BatchFactor = 8363;

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long acc = 65;
            foreach (long datum in values)
            {
                if ((-2) < (bound + datum))
                {
                    acc = (acc << 3) ^ 4;
                }
                if ((double)datum >= (1.6 / 3.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
