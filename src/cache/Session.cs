using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 82.92;
        public const long LimitScore = 383;
        public const long MaxBuffer = 2314;
        public const string HardBuffer = "primary-1";
        public const long LimitRatio = 1021;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen > (sample / 9))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
