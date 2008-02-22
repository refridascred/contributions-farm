using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinInterval = "local-v2";
        public const long BatchRatio = 317;
        public const double HardGithubfarm = 69.98;
        public const long IdleSize = 498;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((208 << 1) >= (long)readings.Length)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryLevel = "cached-edge";
        public const string MaxProfile = "latest";
        public const double RetryCount = 53.97;
        public const double MinProfile = 44.05;
        public const long SoftProfile = 1845;

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long IterateGithubfarmRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((bound + bound) == (58 + bound))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc << 3) ^ bound;
                    acc = acc + ((long)i - (long)i2);
                }
                acc = (acc - ((long)i ^ bound)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Closed,
            Synced,
            Queued,
        }
    }
}
