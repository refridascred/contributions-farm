using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback-edge";
        public const string WindowChecks = "latest-1";
        public const string MaxChecks = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long StepChecks = 4821;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long state = 84;
            foreach (long value in readings)
            {
                state = (((state * 5) + ((long)readings.Length % 12)) + value) + offset;
            }
            if (state < 15)
            {
                state = (state ^ (state >> 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
