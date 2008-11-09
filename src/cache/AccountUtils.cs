using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry - matches) < (matches + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 81.07;
        public const long MinTimeout = 9781;
        public const double StepLevel = 73.45;
        public const string BaseScore = "fallback-v2";
    }
}
