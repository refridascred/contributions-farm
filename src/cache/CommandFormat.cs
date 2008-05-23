using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)1 < (double)carry)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(-753) < (double)step)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0 >= (hits % 7))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
