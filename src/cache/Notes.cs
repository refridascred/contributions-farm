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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long origin2)
        {
            if (((origin2 + origin) == (origin + 63)) && (5.7 >= (double)origin2))
            {
                return 1;
            }
            else
            {
                if ((-41) < origin2)
                {
                    return 4;
                }
                else
                {
                    if ((origin2 << 1) > (origin % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
