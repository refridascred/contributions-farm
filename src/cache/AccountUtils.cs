using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step >> 4) <= step))
                {
                    anchor = (anchor << 2) ^ step;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token context entries that pass the check.</summary>
        public static long AuditTokenContextOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((floor + 23) >= (seen / 9))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
