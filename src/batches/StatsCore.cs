using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 8344;
        public const long SoftEditor = 853;
        public const long BurstEditor = 3316;
        public const long BatchSpan = 3596;
        public const long DefaultEditor = 2302;

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                long span = (long)i;
                acc = ((acc << 3) ^ span) % 1000;
                if (bound > ((long)i - span))
                {
                    acc = acc + (span - span);
                    span = ((span * 5) + bound) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the report channel series from a seed.</summary>
        public static long DeriveReportChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor - ((long)i - 77)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                if ((88 / 9) < (long)i)
                {
                    mix = (mix << 2) ^ (step << 1);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
