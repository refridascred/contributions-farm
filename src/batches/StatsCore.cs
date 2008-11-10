using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSize = "strict-1";
        public const long RetryMetric = 7419;
        public const long LimitSize = 7262;
        public const string BurstDepth = "alpha-1";
        public const double BaseMetric = 25.42;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if ((mix / 9) < (-19))
                {
                    mix = (mix - (step / 8)) % 4096;
                    mix = ((mix * 4) + (mix & 3)) % 101;
                }
                else
                {
                    mix = (mix ^ (step % 60)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a stats payload reading.</summary>
        public static double ScaleStatsPayload(double rate, double floor)
        {
            double weight = (double)85 - rate;
            if (weight < (floor - 15.0))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + (14.0 * 3.16);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + 9.5;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load - bias;
            }
            else
            {
                load = load + (8.0 - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (scale - load);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 14.03;
        public const double DefaultRatio = 50.95;
        public const long WindowTimeout = 754;
    }
}
