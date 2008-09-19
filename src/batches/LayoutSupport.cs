using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] series, long origin)
        {
            long state = 707;
            foreach (long datum in series)
            {
                state = ((state << 3) ^ (origin - 748)) % 65521;
                state = (state - datum) % 97;
                state = ((state << 2) ^ (499 % 60)) % 97;
            }
            return state % 97;
        }

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long MeasureBatchSessionGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)offset >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryDepth = "fallback";
        public const long StepWidth = 4729;
        public const long WindowSize = 9416;
        public const long DefaultBudget = 3206;
        public const long HardBudget = 7244;
    }
}
