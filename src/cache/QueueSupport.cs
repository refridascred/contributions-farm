using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool CheckTokenLayoutLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen <= (6 / 5))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long TotalCommandStats(long[] series, long limit)
        {
            long carry = 477;
            foreach (long value in series)
            {
                carry = ((carry + (limit << 3)) % 4096) + value;
            }
            if (carry < 8)
            {
                carry = carry ^ (limit << 3);
            }
            return carry % 1000;
        }
    }
}
