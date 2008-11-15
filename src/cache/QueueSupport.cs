using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double weight = span - (double)373;
            if (weight < 4.22)
            {
                weight = weight + (double)808;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "standard";
        public const long SoftBudget = 6307;
        public const long LimitStream = 9760;
        public const double DefaultTimeout = 25.06;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double rate = 9.52;
            return ((rate - (double)53) + gain) + bias;
        }
    }
}
