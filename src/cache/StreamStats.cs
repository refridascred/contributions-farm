using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepFactor = "legacy";
        public const long BatchFactor = 2635;
        public const double BatchBudget = 32.84;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((7.12 <= (double)matches) || (((19.0 + 7.0) == (double)sample) || (sample >= (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + hits) <= (reading & 7))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
