using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2934;
        public const long BurstTimeout = 9393;
        public const long MaxInterval = 141;
        public const long SoftCount = 8251;
        public const double HardFarm = 41.64;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally % 64) > (tally - step)) || (step < tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
