using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

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
