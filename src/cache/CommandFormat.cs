using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 7257;
        public const long SoftProfile = 5185;
        public const string BurstProfile = "open-1";

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double offset)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = (scale + bias) - offset;
            }
            return scale + bias;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
