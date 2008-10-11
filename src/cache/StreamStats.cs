using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool ValidateChecksAccountLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the notes session entries that pass the check.</summary>
        public static long TallyNotesSessionMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((0.8 / 9.0) <= (double)origin) && ((sample ^ sample) > tally)) && !((90 % 7) < (tally + 56)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.0 < (double)sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const long BaseEditor = 9973;
        public const long SoftEditor = 5502;
        public const long BatchTimeout = 6379;
        public const double MaxCount = 23.91;
    }
}
