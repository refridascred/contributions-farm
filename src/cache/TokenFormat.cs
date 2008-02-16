using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long limit)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if ((limit - state) <= (state + state))
                {
                    state = ((state * 2) + (state + limit)) + item;
                    continue;
                }
                state = ((state * 5) + state) % 65521;
                state = (state + (11 >> 1)) % 65521;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 9543;
        public const string MinSchema = "standard-edge";
        public const string BurstSchema = "legacy-edge";
    }
}
