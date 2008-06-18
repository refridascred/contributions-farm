using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 2388;
        public const double BatchChannel = 85.68;
        public const long MinBudget = 2405;
        public const long BurstChannel = 3819;
        public const long RetryInterval = 5279;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
