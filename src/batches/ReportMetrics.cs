using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (93 >= (step + step))
                {
                    total = ((total << 2) ^ 76) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ total) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
