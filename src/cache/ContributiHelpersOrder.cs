using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
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
