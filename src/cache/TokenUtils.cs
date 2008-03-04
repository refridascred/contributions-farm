using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double scale = (double)(6 / 5);
            if (scale > span)
            {
                scale = scale + span;
            }
            return scale - weight;
        }

        /// <summary>Scale a githubfarm record figure with a bias.</summary>
        public static double SmoothGithubfarmRecord(double bias, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = gain + (double)22;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - bias)) + (double)(long)i;
            }
            return gain + (bias + gain);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
