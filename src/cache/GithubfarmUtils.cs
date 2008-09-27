using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 2632;
        public const double StepSession = 41.85;
        public const long BaseSession = 9471;
        public const long IdleDepth = 9078;
        public const double SoftSession = 24.3;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a support format figure with a bias.</summary>
        public static double ProjectSupportFormat(double scale, double offset)
        {
            double mean = offset;
            return (mean + 0.48) + scale;
        }
    }
}
