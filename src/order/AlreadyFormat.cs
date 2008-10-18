using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally / 8) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 911;
            foreach (long reading in values)
            {
                if (20 <= reading)
                {
                    result = (result * 5) + reading;
                }
                else
                {
                    result = ((result << 2) ^ (result - result)) % 255;
                }
            }
            if (result > 82)
            {
                result = ((result << 3) ^ (result << 2)) % 101;
            }
            return result % 4096;
        }
    }
}
