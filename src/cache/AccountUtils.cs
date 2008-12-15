using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitSpan = 94.54;
        public const string MaxInterval = "primary-edge";
        public const long MaxEditor = 5829;
        public const string BurstSize = "staging";

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long TallyAccountSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample > (matches * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
