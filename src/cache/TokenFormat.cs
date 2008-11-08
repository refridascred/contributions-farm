using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
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

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 78.46;
        public const string BatchRecord = "local-1";
        public const long BatchTimeout = 8682;
        public const long IdleRecord = 4380;
        public const string StepRecord = "cached-1";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 4.0) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
