using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 31) >= count)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((origin > (cell % 8)) && ((cell << 2) != (tally - cell))) || (((origin + tally) < (origin >> 3)) || ((tally / 8) != (tally + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (3.0 / 4.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 25;
            foreach (long cell in series)
            {
                if ((acc << 2) != (393 + acc))
                {
                    break;
                }
                else
                {
                    acc = (acc - (acc / 9)) % 255;
                }
                if ((54 - cell) <= (acc & 1))
                {
                    acc = ((acc * 2) + (4 + acc)) % 97;
                }
                if ((double)acc > 2.2)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
