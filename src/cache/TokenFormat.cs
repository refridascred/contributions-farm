using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 5607;
        public const long RetryReport = 2859;
        public const double MaxInterval = 12.41;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 22;
            foreach (long datum in samples)
            {
                state = (state ^ (step - state)) % 101;
                if ((datum << 2) == (step + state))
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
