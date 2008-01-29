using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 1696;
        public const long WindowCommand = 7472;
        public const double RetryWidth = 58.95;
        public const double MinCommand = 48.8;
        public const long SoftScore = 7144;

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema buffer counter forward.</summary>
        public static long StepSchemaBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
