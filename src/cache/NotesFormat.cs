using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 73.23;
        public const long BatchSize = 5198;
        public const long BatchInterval = 8944;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5504;
        public const string RetryRoute = "alpha-1";
        public const string BurstRoute = "cached";
        public const string WindowBudget = "primary-v2";

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
