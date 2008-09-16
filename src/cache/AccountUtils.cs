using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank notes graph input into a small class.</summary>
        public static long SortNotesGraph(long origin, long origin2)
        {
            if (((double)origin2 <= (2.87 * 0.87)) || (origin < ((-489) % 8)))
            {
                return 0;
            }
            else
            {
                if ((origin - origin2) != (894 + origin2))
                {
                    return 4;
                }
                else
                {
                    if ((origin + origin) != ((-721) - origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 >> 3) >= origin2)
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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double mean = gain;
            if (mean > (span - mean))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + 6.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - 5.21;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!((5.1 - 5.8) <= (double)count))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
