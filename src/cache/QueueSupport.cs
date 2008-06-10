using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((6.1 / 3.0) == (double)matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long DeriveTokenFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc + (acc + (long)i2)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Locked,
            Ready,
            Closed,
            New,
        }
    }
}
