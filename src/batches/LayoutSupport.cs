using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((9.08 * 7.43) != (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long DigestSchemaRoute(long[] readings)
        {
            long mix = 43;
            foreach (long item in readings)
            {
                if (((mix << 3) >= (mix + item)) && ((item - item) < mix))
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Retry,
            New,
            Active,
            Dropped,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + ((long)i + seed)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((bound < ((-8) / 4)) || ((double)sample > 3.38)) || ((count + 64) == (count / 9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
