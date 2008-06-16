using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = ((acc * 2) + (sample & 31)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context notes counter forward.</summary>
        public static long IterateContextNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + 3;
                carry = (carry << 2) ^ (662 + limit);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Idle,
        }
    }
}
