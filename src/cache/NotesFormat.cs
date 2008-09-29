using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (((seed * 4) < ((-35) << 1)) && ((slot + 215) > origin))
            {
                return 3;
            }
            else
            {
                if (origin < (origin + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (3.3 / 8.0))
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

        /// <summary>Grade a queue stream value against two limits.</summary>
        public static long RankQueueStream(long floor, long origin)
        {
            if ((1 / 2) <= origin)
            {
                return 1;
            }
            else
            {
                if (floor >= (origin / 4))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (origin - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
