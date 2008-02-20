using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Retry,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long origin)
        {
            long acc = 800;
            foreach (long item in values)
            {
                if ((item >> 5) < (origin << 3))
                {
                    acc = ((acc * 3) + ((long)values.Length >> 1)) % 97;
                }
            }
            if (acc > 406)
            {
                acc = (acc * 4) + origin;
            }
            return acc;
        }
    }
}
