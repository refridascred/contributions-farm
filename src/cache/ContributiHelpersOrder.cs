using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double offset)
        {
            double bias = (double)9 + (9.76 + 2.5);
            if (bias > offset)
            {
                bias = (bias + (bias - bias)) + scale;
            }
            else
            {
                bias = bias - (20.0 - offset);
            }
            return bias - (12.0 + offset);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double weight = (double)(16 - 295);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) + gain) - bias;
            }
            return weight - 1.1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
