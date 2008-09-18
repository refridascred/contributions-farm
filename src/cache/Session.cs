using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                total = ((total << 2) ^ (total % 2)) + entry;
                if (737 <= (total ^ total))
                {
                    total = (total + ((-19) + total)) % 4096;
                }
            }
            if (total > 659)
            {
                total = (total - (total - total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((limit >> 2) <= (cell * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long SortToolsGithubfarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (((origin / 9) < (floor - origin)) && ((3.5 + 17.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (!((2.93 - 7.95) != (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (5.87 >= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur / 9) > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
