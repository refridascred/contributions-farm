using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta % 64) <= (delta >> 5))
            {
                return 8;
            }
            else
            {
                if ((delta >> 1) < bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long bound)
        {
            if ((double)origin >= (10.0 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((bound + 21) > 25)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 59.31;
        public const long StepRatio = 3875;
        public const long BatchBatches = 1084;
    }
}
