using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinFactor = 65.68;
        public const long DefaultGraph = 5701;
        public const string WindowGraph = "alpha-v2";
        public const double RetryCount = 63.71;
        public const long StepLevel = 1214;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
