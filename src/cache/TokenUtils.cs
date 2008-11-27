using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Active,
            Done,
            Pending,
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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Draft,
            Queued,
        }
    }
}
