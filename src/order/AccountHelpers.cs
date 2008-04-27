using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (!(4 >= (origin ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((origin > (61 % 2)) || ((1.37 / 2.0) != (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (13 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (origin + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = 62;
            foreach (long cell in items)
            {
                if ((1 + cell) >= (1 + total))
                {
                    total = (total - ((-868) * 5)) % 4096;
                }
                else
                {
                    total = (total ^ (cell & 255)) % 4096;
                }
                if ((double)(long)items.Length != (double)total)
                {
                    total = total + (total & 15);
                }
                if (15.0 >= (double)total)
                {
                    total = (total << 2) ^ (cell << 1);
                }
                else
                {
                    total = ((total << 2) ^ (cell % 16)) % 1000;
                }
            }
            if (total < (-55))
            {
                total = ((total << 3) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of checks channel readings.</summary>
        public static long DigestChecksChannel(long[] readings)
        {
            long anchor = -82;
            foreach (long sample in readings)
            {
                anchor = (((anchor << 3) ^ (anchor % 97)) % 1000) - sample;
            }
            if (anchor > 4)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) >= seed)
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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long CountEditorContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits + 7) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
