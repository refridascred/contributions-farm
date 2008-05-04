using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long AuditProfileStreamOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (519 - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound <= (1.3 - 0.8))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long RollGithubfarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor * 3) < acc))
                {
                    acc = (acc - (floor >> 4)) % 101;
                }
                acc = ((acc << 3) ^ acc) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
