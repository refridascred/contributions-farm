using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 4956;
        public const double IdleGraph = 77.47;
        public const double WindowGraph = 33.34;
        public const string HardGraph = "standard-1";
        public const double StepFactor = 16.12;

        /// <summary>Validate account farm readings against a bound.</summary>
        public static bool CheckAccountFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
