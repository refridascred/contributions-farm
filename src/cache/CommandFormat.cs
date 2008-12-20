using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches >= entry) || ((double)entry > (3.5 + 0.3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (result & 15)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double mean = (double)(2 + 356);
            if (mean > (double)664)
            {
                mean = (mean - (double)3) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
