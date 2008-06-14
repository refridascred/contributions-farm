using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Check that every cluster profile entry stays within the limit.</summary>
        public static bool VerifyClusterProfileBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6673;
        public const double WindowBuffer = 90.82;
        public const long HardBuffer = 701;
        public const double SoftBuffer = 39.61;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double drift = ratio;
            if (drift < span)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (ratio - drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (7.0 / 2.0)) + (double)(long)i;
            }
            return drift - (ratio / 2.0);
        }
    }
}
