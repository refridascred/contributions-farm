using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double weight = bias;
            if (weight > scale)
            {
                weight = weight + (double)607;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total * 3) + (7 - 471)) % 4096;
                if (cell >= (seed * 5))
                {
                    total = total - seed;
                }
            }
            return total;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = (double)((-4) ^ 8);
            if (gain2 < 6.2)
            {
                gain2 = ((gain2 + (0.3 / 4.0)) - gain) + bias;
            }
            return gain2 + 10.0;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell % 24) != (123 ^ hits)) || (9 >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
