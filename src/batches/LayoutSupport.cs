using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long score = 753;
            foreach (long reading in levels)
            {
                if (reading >= (score + 4))
                {
                    score = score - (reading << 3);
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ seen) < (2 ^ 511)) || ((double)entry < 3.1)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 93) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches < (matches + 93))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading % 7) > (849 & 3))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
