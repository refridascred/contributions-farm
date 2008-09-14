using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((7.0 * 17.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (prev <= (target / 5))
                {
                    return 0;
                }
                else
                {
                    if (bound > (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (1.85 * 18.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long SortOrderAccount(long offset, long bound)
        {
            if ((double)offset >= 5.2)
            {
                return 1;
            }
            else
            {
                if (!((double)offset <= (17.0 / 5.0)))
                {
                    return 6;
                }
                else
                {
                    if ((2 + 233) == (bound << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound > ((-753) << 1)) || ((offset << 1) != (bound << 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
