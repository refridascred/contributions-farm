using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long state = 718;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    state = (state - 641) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (bound & 63);
                }
            }
            if (state < 27)
            {
                state = ((state * 5) + (bound % 24)) % 255;
            }
            return state % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 2.69;
        public const double WindowLevel = 76.28;
        public const long BurstSupport = 4981;
        public const string HardSupport = "latest-edge";

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = (double)(731 - 356);
            if (weight < 10.0)
            {
                weight = (weight - weight) + scale;
            }
            return weight - span;
        }
    }
}
