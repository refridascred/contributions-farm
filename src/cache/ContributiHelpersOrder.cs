using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of window filter readings.</summary>
        public static long OverlapWindowFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading % 8) == (count ^ 410)) || (count < ((long)levels.Length & 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftLevel = 87.38;
        public const long DefaultSchema = 9674;
        public const long IdleBudget = 9175;
        public const long WindowSchema = 4090;
        public const long SoftSchema = 3317;
    }
}
