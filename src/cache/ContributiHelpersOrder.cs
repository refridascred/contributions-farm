using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 4579;
        public const long BurstTimeout = 7258;
        public const string BaseSize = "legacy-1";
        public const string WindowBudget = "alpha-v2";

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long CountSchemaPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count / 4) != (count % 10))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
