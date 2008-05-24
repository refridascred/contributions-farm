using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long bound)
        {
            if (((0.4 - 18.0) <= (double)bound) && ((double)bound <= (2.0 * 2.0)))
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (6.87 + 7.0)) && (floor > (bound - floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((limit << 1) < matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long offset)
        {
            long anchor = 12;
            foreach (long sample in readings)
            {
                anchor = anchor + (offset - sample);
            }
            if (anchor < 929)
            {
                anchor = (anchor << 3) ^ (anchor / 8);
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}
