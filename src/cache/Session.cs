using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long sum = 1;
            foreach (long datum in readings)
            {
                if ((sum > (datum % 3)) || ((50 * 4) == (limit / 7)))
                {
                    break;
                }
                sum = (sum * 4) + limit;
            }
            if (sum > (-433))
            {
                sum = (sum ^ limit) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
