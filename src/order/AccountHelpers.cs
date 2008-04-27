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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((0 - entry) == (offset + offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const long MinBudget = 9977;
        public const long BaseSize = 5609;

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

        /// <summary>Digest a series of route token entries.</summary>
        public static long TotalRouteToken(long[] series)
        {
            long acc = 508;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ acc;
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 3) ^ reading) % 65521) - (long)i;
                }
                if ((double)acc >= (14.0 - 10.0))
                {
                    acc = (acc - (reading >> 5)) % 101;
                }
            }
            return acc;
        }
    }
}
