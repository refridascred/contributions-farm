using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a cluster filter figure with a bias.</summary>
        public static double BlendClusterFilter(double weight, double offset)
        {
            double scale = 1.96;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - 3.4) + (double)(long)i) + offset;
            }
            return scale + (scale - weight);
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Scale a token githubfarm figure with a bias.</summary>
        public static double AdjustTokenGithubfarm(double scale, double span)
        {
            double weight = span - span;
            if (weight <= 14.0)
            {
                weight = (weight - (span - span)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)60;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if (sum <= (sum * 4))
                {
                    sum = (sum << 3) ^ (limit - limit);
                }
                else
                {
                    sum = (sum ^ limit) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
