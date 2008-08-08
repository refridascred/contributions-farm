using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 5.79;
        public const long LimitFactor = 2660;
        public const long HardAlready = 1683;
        public const string BurstTimeout = "alpha-edge";
        public const long BaseAlready = 9714;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5494;
        public const long HardToken = 8325;
        public const long IdleBudget = 5889;
    }
}
