using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if (limit < (939 << 3))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) < 4)
                {
                    return 5;
                }
                else
                {
                    if (((limit - seed) <= (43 - limit)) || ((limit + seed) == (778 + 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) < 85)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) > (771 + (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
