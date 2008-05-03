using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheInterval = 22.36;
        public const double SoftLevel = 88.38;
        public const long BurstFactor = 2907;
        public const long CacheCommand = 6089;
        public const long MaxSpan = 4235;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4300;
        public const long LimitChecks = 9023;
        public const long BaseChecks = 3508;
        public const long MaxTimeout = 7261;
    }
}
