using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 46.75;
        public const string IdleStream = "staging-1";
        public const double BurstScore = 32.52;
        public const double BatchInterval = 15.48;
    }
}
