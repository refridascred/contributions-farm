using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the order schema entries that pass the check.</summary>
        public static long AuditOrderSchemaHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 6) < (hits ^ value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)floor <= (double)7)
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                    mix = (mix - (floor - floor)) % 97;
                }
                mix = (mix + (long)i) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph entry entries that pass the check.</summary>
        public static long MeasureGraphEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + seen) <= (seen * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstSpan = 21.64;
        public const double SoftBuffer = 74.22;
        public const string RetrySize = "local-1";
        public const double MinBuffer = 84.97;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
