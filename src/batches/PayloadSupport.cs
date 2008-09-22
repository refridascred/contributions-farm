using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)datum <= (double)2) && ((datum >> 3) < (datum >> 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                if ((state + 30) != (state * 4))
                {
                    state = (((state << 3) ^ (state - state)) % 1000) ^ value;
                }
            }
            if (state > 7)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Validate profile cluster readings against a bound.</summary>
        public static bool CheckProfileClusterRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
