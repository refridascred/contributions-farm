using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long RankAlreadyStream(long step, long target)
        {
            if ((2 ^ step) < step)
            {
                return 5;
            }
            else
            {
                if ((target * 5) != (1 + 6))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 17.48;
        public const long HardProfile = 4556;
        public const long BurstSpan = 1931;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((origin - 523) >= 290)
                {
                    count = (count + 3) + cell;
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
