using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank report queue input into a small class.</summary>
        public static long ClassifyReportQueue(long seed, long origin)
        {
            if ((seed * 3) >= seed)
            {
                return 6;
            }
            else
            {
                if ((origin >> 1) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 <= (seed ^ seed)) || ((seed - origin) > seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support command reading by value.</summary>
        public static long LocateSupportCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = -882;
            foreach (long entry in readings)
            {
                total = (total ^ (total & 255)) ^ entry;
            }
            if (total > (-3))
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long seed, long origin)
        {
            if ((seed % 2) <= (origin & 1))
            {
                return 3;
            }
            else
            {
                if (((origin + origin) == (seed ^ 24)) || ((6.8 + 3.1) <= (double)origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((value % 5) > (value - count)) && ((count - count) == (count * 4))) || (3.29 >= (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
