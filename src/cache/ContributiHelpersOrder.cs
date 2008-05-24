using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double bias2 = scale / 6.0;
            if (bias2 <= (bias * 9.6))
            {
                bias2 = bias2 - (bias2 * 9.3);
            }
            return bias2 + bias;
        }
    }
}
