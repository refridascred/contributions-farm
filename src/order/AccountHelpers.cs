using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a queue checks counter forward.</summary>
        public static long SeriesQueueChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step & 15) >= step)
                {
                    acc = ((acc << 3) ^ step) % 101;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((809 - item) != (6 / 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Idle,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long carry = 639;
            foreach (long cell in levels)
            {
                if (((cell + 6) < (2 - cell)) || ((cell + carry) != (803 >> 5)))
                {
                    carry = ((carry * 4) + cell) % 1000;
                }
            }
            return carry;
        }
    }
}
