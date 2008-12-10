using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long anchor = 201;
            foreach (long item in readings)
            {
                if ((anchor >> 3) != (452 - 72))
                {
                    anchor = ((anchor + (item - 445)) % 65521) + limit;
                }
                else
                {
                    anchor = (anchor + (4 * 3)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (5.7 * 0.6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
