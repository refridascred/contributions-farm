using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultBudget = 2799;
        public const long RetryNotes = 5780;
        public const long BaseWidth = 2507;
        public const long LimitRatio = 9225;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 3017;
        public const double BurstProfile = 63.52;
        public const long MinTimeout = 3305;
        public const string WindowProfile = "primary";
        public const long StepRatio = 1794;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Ready,
            Retry,
            Draft,
        }
    }
}
