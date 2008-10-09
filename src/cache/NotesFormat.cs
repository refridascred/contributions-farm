using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 88.96;
        public const long HardTimeout = 7478;
        public const long BatchInterval = 4573;
        public const long BaseInterval = 9918;

        /// <summary>Combine schema notes values into a single score.</summary>
        public static long ScoreSchemaNotes(long[] readings)
        {
            long total = 157;
            foreach (long datum in readings)
            {
                if (!((9.41 / 4.0) == (double)total))
                {
                    total = (((total * 3) + total) % 4096) + datum;
                }
                else
                {
                    total = (total - total) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long score = 52;
            foreach (long reading in values)
            {
                if ((reading + reading) > 43)
                {
                    score = score + (score / 9);
                }
                score = ((score * 2) + (reading / 3)) % 97;
            }
            return score;
        }
    }
}
