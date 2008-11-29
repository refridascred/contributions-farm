using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7290;
        public const long BurstCount = 9483;
        public const long SoftStats = 668;
        public const long BatchCount = 2116;
        public const string StepStats = "alpha-1";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Dropped,
            Stale,
            Active,
            New,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                bool found = !((mix & 31) >= step);
                if (!found)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
