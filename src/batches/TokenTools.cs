using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long AuditOrderAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)count == (13.0 - 4.51)) && (((item + item) >= (count << 3)) || (count < (29 & 31))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
