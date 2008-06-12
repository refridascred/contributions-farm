using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate report payload readings against a bound.</summary>
        public static bool ValidateReportPayloadRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepDepth = 4292;
        public const double StepRatio = 66.29;
        public const long MinReport = 7349;
        public const string CacheLevel = "cached";
        public const string DefaultDepth = "stable";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + offset;
            }
            return drift + drift;
        }
    }
}
