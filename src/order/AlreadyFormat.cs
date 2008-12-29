using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Locate a queue support reading by value.</summary>
        public static long FindQueueSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long AuditTokenOrderMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 3) > tally)
                {
                    tally = ((tally + 3) + cell) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long AuditGraphChannelGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 127) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((0.1 / 8.0) == (double)offset)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
