using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((double)(-96) == (double)hits) || (limit >= (hits + 25)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((result + (long)i) == (29 + origin)))
                {
                    break;
                }
                if (!(((long)i != (506 >> 4)) || ((8.2 - 5.8) <= (double)origin)))
                {
                    result = result + (867 + (long)i);
                    result = (result + (result * 3)) % 101;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if (0.1 <= (double)seed)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long bound)
        {
            long span = step ^ bound;
            if ((step << 2) <= (span - span))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) != (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
