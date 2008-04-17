using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((8.0 * 7.44) < (double)hits)
                {
                    hits = ((hits + 1) + cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) < (tally - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + 817) >= (long)i)
                {
                    mark = (mark * 4) + seed;
                    mark = mark - seed;
                }
                else
                {
                    mark = (mark ^ seed) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
