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

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long SortFormatSchema(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((2.5 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((642 ^ next) >= (next + next))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
