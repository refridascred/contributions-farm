using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool GuardChannelEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7044;
        public const long IdleDepth = 8984;
        public const double DefaultWindow = 71.55;
        public const long BaseWindow = 6887;
        public const long IdleWindow = 6662;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Idle,
            Ready,
        }
    }
}
