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

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit - 157) <= (count + limit))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Iterate the order window series from a seed.</summary>
        public static long DeriveOrderWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = sum ^ ((long)i / 8);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
