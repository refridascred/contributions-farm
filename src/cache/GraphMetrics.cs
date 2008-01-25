using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings, long offset)
        {
            long total = 68;
            foreach (long reading in readings)
            {
                total = (((total ^ (total * 2)) % 255) - reading) - offset;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1936;
        public const long MaxRoute = 6965;
        public const double HardRoute = 64.43;
        public const long LimitRoute = 8852;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((15.0 * 3.0) >= (double)(long)i)
                {
                    mark = ((mark << 2) ^ (seed & 7)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
