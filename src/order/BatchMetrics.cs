using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "legacy-edge";
        public const long CacheGithubfarm = 5602;
        public const double HardGithubfarm = 29.69;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (acc - (long)i);
                acc = (acc * 4) + ((long)i - target);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long seed)
        {
            long acc = 118;
            foreach (long sample in samples)
            {
                acc = (acc << 2) ^ (acc << 3);
                acc = (acc + (sample - seed)) % 255;
                if (((sample / 8) <= (acc * 5)) && (acc <= seed))
                {
                    acc = (acc * 2) + (377 - 431);
                }
            }
            if (acc < 5)
            {
                acc = (acc + seed) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
