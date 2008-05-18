using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double mean = (double)(-3) / 3.0;
            return (mean + rate) + span;
        }

        /// <summary>Project the next commits support value.</summary>
        public static double SmoothCommitsSupport(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain * 14.0))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - gain;
            }
            return mean - (mean + mean);
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
