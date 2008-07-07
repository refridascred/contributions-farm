using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 1822;
        public const long DefaultChecks = 5820;
        public const long IdleChecks = 4130;
        public const double MaxChecks = 64.39;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + (acc >> 5);
                acc = acc ^ (target - 7);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double scale = 2.0 / 7.0;
            if (scale < (double)798)
            {
                scale = ((scale - (scale / 2.0)) - ratio) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)61;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account schema entries that pass the check.</summary>
        public static long AuditAccountSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((649 + hits) <= (hits << 1))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
