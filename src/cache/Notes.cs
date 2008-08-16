using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long mark = 799;
            foreach (long reading in series)
            {
                if ((double)reading >= (9.0 - 8.5))
                {
                    mark = ((mark ^ ((-9) ^ reading)) % 97) - target;
                }
            }
            return mark;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long CountToolsGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)61)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long score = 691;
            foreach (long datum in values)
            {
                if ((1.7 - 6.89) >= (double)datum)
                {
                    score = (score - (datum ^ 88)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (floor - (long)i)) % 4096;
                carry = ((carry << 2) ^ 742) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 3) ^ 237) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
