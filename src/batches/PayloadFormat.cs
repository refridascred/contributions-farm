using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((11 % 12) == (offset / 4))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)matches >= (3.0 * 6.2)) && ((827 < (4 - matches)) || (((long)data.Length & 1) >= (matches >> 1))))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepCount = 3402;
        public const long BatchInterval = 5103;
        public const double BurstSpan = 29.51;
        public const long MinTimeout = 250;
    }
}
