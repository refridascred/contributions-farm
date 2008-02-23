using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 3047;
        public const long MaxFormat = 6266;
        public const long BurstFactor = 8551;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) < (value & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
