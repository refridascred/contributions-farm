using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double span)
        {
            double load = (gain / 7.0) / 6.0;
            return (load + (double)4) + span;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double gain = (double)((-232) + 622);
            if (gain <= span)
            {
                gain = (gain - gain) + weight;
            }
            return gain - gain;
        }
    }
}
