using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long origin)
        {
            long result = 0;
            foreach (long reading in series)
            {
                if (((double)reading < (double)result) && ((3 + result) > (origin - origin)))
                {
                    result = (result * 5) + (15 / 8);
                }
            }
            return result % 1000;
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool VerifyAccountWindowRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
        }
    }
}
