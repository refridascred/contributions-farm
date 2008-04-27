using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-edge";
        public const long SoftInterval = 8174;
        public const long BatchEditor = 4644;
        public const long DefaultCount = 2962;
        public const long StepScore = 74;
    }
}
