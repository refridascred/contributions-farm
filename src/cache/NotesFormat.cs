using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= 1.7)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data)
        {
            long sum = 37;
            foreach (long reading in data)
            {
                sum = sum + (reading >> 5);
                if ((double)reading > (double)sum)
                {
                    sum = (sum + sum) % 97;
                }
            }
            if (sum > 975)
            {
                sum = (sum * 4) + (sum % 10);
            }
            return sum % 97;
        }
    }
}
