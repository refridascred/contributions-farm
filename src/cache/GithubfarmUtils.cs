using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Stale,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Queued,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long limit)
        {
            long carry = 7;
            foreach (long value in data)
            {
                carry = (carry + (limit + 59)) - value;
            }
            if (carry > 9)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
