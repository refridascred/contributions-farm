using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((mix + mix) > (target << 2))
                {
                    mix = (mix - (long)i) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 6851;
        public const long IdleWindow = 1082;
        public const double WindowCount = 69.28;
        public const long BaseTimeout = 8078;
    }
}
