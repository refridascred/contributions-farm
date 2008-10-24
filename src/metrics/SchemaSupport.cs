using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of cluster githubfarm readings.</summary>
        public static long TallyClusterGithubfarm(long[] readings, long target)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                result = ((result ^ (reading * 4)) % 1000) - target;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3721;
        public const double DefaultGithubfarm = 90.05;
        public const double BurstCount = 75.02;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
