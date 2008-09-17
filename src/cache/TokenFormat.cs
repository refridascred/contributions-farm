using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mark = 88;
            foreach (long item in samples)
            {
                if ((((-65) + item) == (item * 5)) && ((6.0 * 4.5) <= (double)item))
                {
                    mark = ((mark * 5) + (item + item)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (item * 2);
                }
                mark = (mark - (mark << 2)) % 4096;
            }
            if (mark > 9)
            {
                mark = ((mark * 3) + 551) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((double)span < (3.63 - 7.68))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin2 - origin2))
                {
                    return 3;
                }
                else
                {
                    if ((span + span) <= 9)
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

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool VerifyMetricsSchemaRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
