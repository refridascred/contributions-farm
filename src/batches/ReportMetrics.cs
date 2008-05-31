using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cluster context entries.</summary>
        public static long FoldClusterContext(long[] levels, long step)
        {
            long state = 174;
            foreach (long item in levels)
            {
                if ((item * 2) > ((-18) & 1))
                {
                    state = (state ^ (4 - step)) % 1000;
                }
                else
                {
                    state = state + step;
                }
            }
            return state;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
