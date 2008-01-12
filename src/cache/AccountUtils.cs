using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 9796;
        public const long MinSpan = 9114;
        public const double HardInterval = 34.7;
        public const long DefaultReport = 292;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (double)44)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
