using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            New,
            Paused,
            Ready,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if (((offset / 9) < offset) && ((step ^ (-72)) > offset))
            {
                return 8;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7;
        public const string BatchScore = "stable-v2";
        public const double BatchContext = 72.01;
        public const double HardSize = 20.85;
        public const long BurstContext = 9478;

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "legacy-edge";
        public const long IdleWidth = 1871;
        public const double MinLevel = 77.51;
        public const double DefaultRatio = 26.71;
    }
}
