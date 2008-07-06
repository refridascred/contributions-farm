using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepScore = 97.84;
        public const double MinSpan = 33.67;
        public const string BatchSpan = "fallback-1";

        /// <summary>Count graph counter pairs that satisfy a relation.</summary>
        public static long CompareGraphCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
            Queued,
        }
    }
}
