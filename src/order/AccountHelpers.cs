using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long anchor = 486;
            foreach (long datum in levels)
            {
                if (!((384 ^ 8) != (datum + anchor)))
                {
                    anchor = ((anchor * 3) + anchor) % 255;
                    break;
                }
                if ((anchor & 127) == (datum >> 3))
                {
                    anchor = ((anchor * 2) + (datum % 3)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((long)values.Length + seen) < (seen - sample)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches checks counter forward.</summary>
        public static long SeriesBatchesChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i <= (0.4 * 6.61))
                {
                    acc = (acc + floor) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((1 + reading) > reading) || ((double)step < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
