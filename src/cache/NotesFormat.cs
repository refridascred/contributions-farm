using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a token queue value against two limits.</summary>
        public static long SortTokenQueue(long origin, long seed)
        {
            long diff = origin - seed;
            if ((3.0 - 0.91) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((diff - 1) > (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((3.01 + 2.78) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff > (35 ^ seed)) || ((990 % 100) > (origin + diff)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if (((limit - offset) <= limit) || ((offset + 0) <= offset))
            {
                return 8;
            }
            else
            {
                if ((1.7 / 4.0) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (3.6 / 9.0)) && ((offset + limit) != (offset ^ offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
