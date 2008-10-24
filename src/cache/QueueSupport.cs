using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + target;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a stats githubfarm reading.</summary>
        public static double AdjustStatsGithubfarm(double gain, double floor)
        {
            double bias = (double)25 * 5.1;
            if (bias > (16.0 - bias))
            {
                bias = ((bias - bias) - gain) - floor;
            }
            return bias - bias;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
