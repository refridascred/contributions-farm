using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long mix = 390;
            foreach (long entry in readings)
            {
                if ((mix & 7) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (entry & 15)) - step;
                }
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Retry,
            New,
            Queued,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
