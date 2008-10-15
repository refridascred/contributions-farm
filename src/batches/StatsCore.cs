using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a queue tools pair into a bucket.</summary>
        public static long BucketQueueTools(long target, long bound)
        {
            if ((double)bound != (double)target)
            {
                return 4;
            }
            else
            {
                if ((bound * 4) <= 821)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound < (19.0 / 6.0)) && ((bound % 7) <= (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum % 5) < (94 % 10)) || ((count + datum) > (datum + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long WeighToolsEntry(long[] items, long step)
        {
            long total = -86;
            foreach (long item in items)
            {
                if ((double)step == (16.0 / 7.0))
                {
                    total = total + (item & 255);
                }
                if ((item * 5) >= (total + (long)items.Length))
                {
                    break;
                }
            }
            return total;
        }
    }
}
