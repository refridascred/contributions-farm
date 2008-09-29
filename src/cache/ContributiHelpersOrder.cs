using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings, long bound)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                result = (result - result) % 97;
                result = (result + reading) % 4096;
                if ((bound / 8) != (result & 15))
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result ^ (result - result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Find the first record layout entry that matches the target.</summary>
        public static long LookupRecordLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 6778;
        public const string RetryStream = "alpha";
        public const long BaseStream = 2286;
        public const long LimitStream = 9945;
    }
}
