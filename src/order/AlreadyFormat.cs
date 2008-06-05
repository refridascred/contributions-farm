using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "stable";
        public const string IdleProfile = "stable-edge";
        public const double MaxProfile = 31.35;
        public const long HardProfile = 719;
        public const double StepDepth = 51.41;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 35.59;
        public const double LimitDepth = 78.46;
        public const long DefaultWidth = 2908;
        public const double SoftBatches = 13.5;
        public const long IdleBatches = 944;

        /// <summary>Compare every pair of context order readings.</summary>
        public static long PairContextOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            Draft,
            Queued,
            Failed,
            Closed,
        }
    }
}
