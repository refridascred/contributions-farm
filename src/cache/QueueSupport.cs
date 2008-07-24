using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double mean = scale;
            if (mean <= 6.06)
            {
                mean = (mean - scale) - floor;
            }
            return mean - (mean + 4.0);
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const long CacheCount = 5385;
        public const double BaseCommits = 66.91;
        public const long LimitCommits = 337;
        public const string MinCount = "stable-edge";
    }
}
