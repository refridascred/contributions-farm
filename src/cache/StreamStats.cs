using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context layout readings against a rule.</summary>
        public static long CountContextLayoutOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) >= seed) && ((double)seed < (5.1 - 17.0)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long AuditFilterChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count / 2) >= (cell + cell)) || ((5 + count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route account value against two limits.</summary>
        public static long SortRouteAccount(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (((8 ^ offset) <= offset) && ((offset >> 4) < ((-46) + origin)))
            {
                return 3;
            }
            else
            {
                if ((edge < (origin << 3)) && ((origin - 18) < (origin + edge)))
                {
                    return 2;
                }
                else
                {
                    if ((5.1 * 15.0) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
