using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a window account value against two limits.</summary>
        public static long RankWindowAccount(long seed, long limit)
        {
            if (((seed >> 3) <= (limit - seed)) || ((5 ^ limit) != (seed + limit)))
            {
                return 8;
            }
            else
            {
                if (((limit - seed) > (9 ^ seed)) || ((limit + limit) < (limit ^ seed)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
