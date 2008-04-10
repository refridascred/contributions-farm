using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 75.33;
        public const long BaseQueue = 7907;
        public const long StepQueue = 5579;
        public const long HardQueue = 3573;

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 64.02;
        public const long BaseRatio = 4005;
        public const string MaxTools = "legacy";

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
