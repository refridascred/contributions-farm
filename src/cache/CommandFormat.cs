using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 802;
        public const long StepCount = 4655;
        public const double MaxOrder = 29.17;
        public const long BurstOrder = 4679;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long seed)
        {
            if (!((origin % 97) == (0 * 2)))
            {
                return 6;
            }
            else
            {
                if ((seed * 5) >= 0)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Locked,
            Paused,
            Synced,
        }
    }
}
