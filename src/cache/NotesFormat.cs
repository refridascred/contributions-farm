using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool VerifyGithubfarmContributiLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long floor, long origin)
        {
            if ((double)origin > (2.1 - 11.0))
            {
                return 7;
            }
            else
            {
                if ((floor - origin) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > 8.77)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + origin) > (origin * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) >= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
