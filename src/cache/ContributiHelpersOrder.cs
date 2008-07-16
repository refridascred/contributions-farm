using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 6182;
        public const string MaxFactor = "legacy";
        public const long MaxInterval = 8945;

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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
