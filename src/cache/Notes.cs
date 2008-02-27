using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double AdjustCommandBatch(double gain, double floor)
        {
            double drift = (double)(7 & 31);
            if (drift > gain)
            {
                drift = (drift + (double)1) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5821;
        public const long DefaultStats = 9581;
        public const long StepSpan = 2857;
        public const string SoftStats = "fallback-edge";
        public const long MinStats = 8193;
    }
}
