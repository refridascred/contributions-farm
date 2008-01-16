using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long floor)
        {
            long carry = 89;
            foreach (long reading in levels)
            {
                carry = carry ^ (floor - 4);
                if ((reading << 2) <= (reading << 1))
                {
                    carry = (carry + (floor ^ carry)) % 1000;
                }
                if ((reading % 16) < (carry + reading))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry + (floor + floor);
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Queued,
            Synced,
            Retry,
            New,
        }
    }
}
