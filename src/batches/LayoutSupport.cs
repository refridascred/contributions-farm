using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples)
        {
            long score = 524;
            foreach (long cell in samples)
            {
                score = (score + (464 ^ score)) % 101;
                if ((score + score) <= (score * 3))
                {
                    score = (score ^ (cell * 5)) % 4096;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score % 4096;
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
