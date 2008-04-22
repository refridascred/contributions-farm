using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally < 7.8)
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Synced,
            Pending,
            Stale,
        }
    }
}
