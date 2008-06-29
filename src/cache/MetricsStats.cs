using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!(mix > (long)i))
                {
                    mix = mix - floor;
                    mix = (mix << 3) ^ (mix - floor);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
