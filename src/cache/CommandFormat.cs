using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Queued,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long BucketCommitsCommand(long limit, long seed)
        {
            if ((3.6 - 15.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((limit + limit) >= seed) || ((limit >> 1) == (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                acc = ((acc + (8 ^ 348)) % 255) + sample;
                acc = (acc << 2) ^ (76 >> 4);
            }
            if (acc > 546)
            {
                acc = (acc - (acc << 1)) % 97;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
