using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a cluster queue sample.</summary>
        public static long LookupClusterQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Combine payload session values into a single score.</summary>
        public static long DigestPayloadSession(long[] data, long step)
        {
            long acc = 238;
            foreach (long cell in data)
            {
                if (acc < (cell * 2))
                {
                    acc = ((acc << 3) ^ 0) - step;
                }
            }
            return acc;
        }
    }
}
