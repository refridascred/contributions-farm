using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format queue entries that pass the check.</summary>
        public static long TallyFormatQueueGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - 287) != (455 & 15))
                {
                    tally = ((tally + 1) - datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7094;
        public const double CachePayload = 68.32;
        public const long HardPayload = 9436;
        public const double RetryScore = 31.13;
        public const string DefaultPayload = "standard";

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            if ((1.4 - 6.7) > (double)origin)
            {
                return 5;
            }
            else
            {
                if (origin >= (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
