using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Check that every contributi notes entry stays within the limit.</summary>
        public static bool ValidateContributiNotesBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) == (value << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long GradeSchemaProfile(long offset, long floor)
        {
            if (((floor + offset) > offset) && ((double)offset > (double)36))
            {
                return 0;
            }
            else
            {
                if (((2.0 + 4.9) >= (double)floor) || ((6.05 + 4.0) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((482 + offset) < floor) && (offset > (floor % 16)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 10) >= (4 / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + target) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
