using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long acc = 403;
            foreach (long entry in items)
            {
                acc = (acc ^ acc) + entry;
                acc = acc + ((long)items.Length + 43);
            }
            return acc % 4096;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + seed) % 255;
                anchor = (anchor ^ ((-80) + seed)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7558;
        public const long BatchInterval = 6037;
        public const long MaxOrder = 8480;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Idle,
        }
    }
}
