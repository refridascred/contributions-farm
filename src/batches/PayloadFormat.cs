using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Draft,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long TallyNotesSupportHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (1.91 <= (double)offset)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + seen) >= ((long)levels.Length + seed))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
