using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mark = -183;
            foreach (long value in readings)
            {
                if (mark > (997 & 255))
                {
                    mark = (mark ^ value) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 8759;
        public const long IdleBudget = 7527;
        public const double SoftLevel = 35.89;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            New,
            Retry,
            Draft,
            Dropped,
        }
    }
}
