using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinWidth = 90.36;
        public const long CacheRatio = 1436;
        public const string BatchTools = "open-edge";
        public const double LimitWidth = 41.25;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
