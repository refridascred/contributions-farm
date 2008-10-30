using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum <= 7) && ((double)(long)values.Length > (5.47 / 4.0))) && (((3.0 + 7.8) <= (double)datum) || ((hits << 3) < hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin - offset;
            if ((7.5 <= (double)next) && ((offset + offset) > (offset + next)))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (9.24 - 9.8))
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
