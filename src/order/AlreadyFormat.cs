using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 3924;
        public const long MinNotes = 7817;
        public const string BaseNotes = "standard-1";
        public const long StepSize = 2065;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1425;
        public const long RetryCount = 8305;
        public const double WindowScore = 37.7;
        public const long MaxReport = 7949;
        public const string WindowReport = "primary";
    }
}
