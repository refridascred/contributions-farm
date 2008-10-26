using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 1349;
        public const double MaxWidth = 64.65;
        public const long RetryWindow = 4832;
        public const double LimitInterval = 67.98;
        public const long HardWindow = 4389;

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long total = 716;
            foreach (long cell in values)
            {
                total = (total - cell) - limit;
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
