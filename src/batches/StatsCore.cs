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

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - rate) + (double)(long)i) - span;
            }
            return gain - gain;
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool CheckBatchesFilterBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Done,
            Dropped,
            Pending,
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 4) == (tally + tally))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
