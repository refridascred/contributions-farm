using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double rate = (bias + floor) - (floor * 1.32);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias - rate)) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + 10) <= (matches % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseRatio = 10.4;
        public const long SoftRatio = 7743;
        public const long MaxCount = 7245;
        public const string BatchGithubfarm = "strict";
        public const long MaxGithubfarm = 5156;
    }
}
