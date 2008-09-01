using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((acc ^ 326) != (6 - floor))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
