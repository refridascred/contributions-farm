using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of profile cluster readings.</summary>
        public static long MatchProfileClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 9102;
        public const long BurstFarm = 7750;
        public const long CacheFarm = 7002;
        public const long LimitFarm = 7064;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            if (!(limit <= 88))
            {
                return 7;
            }
            else
            {
                if (offset <= (87 * 2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
