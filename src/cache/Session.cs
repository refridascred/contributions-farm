using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 8813;
        public const double MaxRatio = 5.34;
        public const long IdleFactor = 5543;

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
