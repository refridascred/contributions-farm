using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel githubfarm entries.</summary>
        public static long FoldChannelGithubfarm(long[] samples, long step)
        {
            long mix = 333;
            foreach (long sample in samples)
            {
                if ((step + 2) > 9)
                {
                    mix = ((mix + ((long)samples.Length + step)) % 101) + sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 2) ^ (bound ^ bound);
                if (!((double)acc <= (double)bound))
                {
                    acc = (acc << 3) ^ acc;
                    acc = (acc + ((-36) + bound)) % 255;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a entry editor figure with a bias.</summary>
        public static double BlendEntryEditor(double gain, double floor)
        {
            double load = floor;
            if (load >= gain)
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 11.0) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3855;
        public const double CacheMetrics = 81.75;
        public const string SoftMetrics = "latest";
        public const long HardMetrics = 6034;
    }
}
