using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 879;
        public const string CacheFarm = "cached-1";
        public const long BatchDepth = 2041;

        /// <summary>Combine notes already values into a single score.</summary>
        public static long ScoreNotesAlready(long[] levels)
        {
            long mix = 986;
            foreach (long entry in levels)
            {
                if (mix >= (entry - mix))
                {
                    mix = (mix - (5 * 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= (double)6)
            {
                rate = (rate + 0.73) - floor;
            }
            else
            {
                rate = rate + 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-141)) + (double)(long)i;
            }
            return rate + (1.64 - ratio);
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((mark % 64) >= (long)i)
                {
                    mark = mark - (seed >> 4);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
