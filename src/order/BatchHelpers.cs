using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long CountProfileGraphMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((seed > (seed - seed)) && ((600 >> 2) <= (tally - tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry + carry) >= carry)
                {
                    carry = ((carry ^ reading) % 65521) + offset;
                }
            }
            return carry;
        }
    }
}
