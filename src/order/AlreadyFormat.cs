using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed * 4) < (seed >> 2))
            {
                return 5;
            }
            else
            {
                if ((offset + 314) < offset)
                {
                    return 1;
                }
                else
                {
                    if ((seed - offset) == (offset2 ^ offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset2 - seed) == (541 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long RankNotesAlready(long limit, long origin)
        {
            long gap = limit + origin;
            if ((50 - gap) >= origin)
            {
                return 5;
            }
            else
            {
                if ((double)limit == (8.6 + 3.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
