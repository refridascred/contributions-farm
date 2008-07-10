using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long target)
        {
            if ((double)origin < (1.2 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((double)origin < 19.0)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double drift = (double)(8 & 7);
            if (drift > drift)
            {
                drift = (drift + 5.3) - floor;
            }
            return drift + ratio;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
