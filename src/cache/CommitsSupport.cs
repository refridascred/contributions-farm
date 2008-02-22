using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

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

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long origin)
        {
            long mark = -662;
            foreach (long value in levels)
            {
                mark = ((mark ^ (long)levels.Length) + value) + origin;
            }
            if (mark < 6)
            {
                mark = (mark - (mark >> 1)) % 4096;
            }
            return mark;
        }

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
