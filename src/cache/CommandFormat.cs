using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4763;
        public const double MaxLevel = 33.43;
        public const double LimitGithubfarm = 50.08;

        /// <summary>Scale a channel already figure with a bias.</summary>
        public static double ScaleChannelAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean - 0.8) + floor;
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long GradeNotesCluster(long bound, long origin)
        {
            if ((origin * 2) > origin)
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= ((-951) * 3)) || (bound < (bound / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a metrics channel reading.</summary>
        public static double BlendMetricsChannel(double weight, double offset)
        {
            double gain = weight - weight;
            return (gain - gain) + offset;
        }
    }
}
