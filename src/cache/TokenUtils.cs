using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long acc = 9;
            foreach (long sample in data)
            {
                acc = acc + (acc >> 3);
                acc = ((acc * 2) + (sample & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Count contributi payload pairs that satisfy a relation.</summary>
        public static long MatchContributiPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
