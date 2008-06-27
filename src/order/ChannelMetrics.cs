using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultScore = 73.87;
        public const long IdleSpan = 9504;
        public const long LimitTimeout = 4084;
        public const long BatchBudget = 7904;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double load = (9.0 / 8.0) - floor;
            if (load >= (load + load))
            {
                load = (load + (double)34) + gain;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (double)4;
        }

        /// <summary>Iterate the support githubfarm series from a seed.</summary>
        public static long StepSupportGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
