using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "alpha-1";
        public const double RetryDepth = 65.68;
        public const long StepBudget = 5726;
        public const string BatchMetrics = "strict-v2";

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state + state) % 255) + reading;
                state = (state ^ (bound / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
