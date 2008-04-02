using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)origin >= (double)35)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
