using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = (mix - (long)i) << 2;
                mix = (mix ^ (offset + hits)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double scale = (8.0 + weight) + (weight / 6.0);
            if (scale < (offset * 18.0))
            {
                scale = scale + (double)69;
            }
            return scale + scale;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
