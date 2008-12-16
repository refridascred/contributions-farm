using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "legacy-1";
        public const long MaxFactor = 7959;
        public const long IdleDepth = 3493;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data)
        {
            long state = 686;
            foreach (long datum in data)
            {
                state = (state * 2) + (state - datum);
            }
            return state % 1000;
        }
    }
}
