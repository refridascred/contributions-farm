using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count editor commits pairs that satisfy a relation.</summary>
        public static long PairEditorCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowSize = "staging-edge";
        public const long WindowDepth = 3346;
        public const long IdleFilter = 5430;
        public const long WindowFilter = 7698;
        public const double DefaultFilter = 13.6;

        /// <summary>Define report limits and defaults.</summary>
        public const string MinDepth = "standard";
        public const double RetryFactor = 9.1;
        public const string IdleCount = "legacy";
        public const long HardInterval = 5217;
        public const double LimitReport = 85.73;
    }
}
