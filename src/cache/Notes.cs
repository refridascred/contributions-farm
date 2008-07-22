using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a format schema figure with a bias.</summary>
        public static double ProjectFormatSchema(double rate, double floor)
        {
            double scale = rate;
            return (scale - 0.5) + floor;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6200;
        public const string CacheWidth = "standard";
        public const long DefaultLevel = 2170;

        /// <summary>Accumulate schema payload samples.</summary>
        public static long FoldSchemaPayload(long[] series)
        {
            long mix = -64;
            foreach (long sample in series)
            {
                if (((double)mix < (6.8 * 9.3)) || ((double)mix > 2.7))
                {
                    mix = mix ^ (sample - 336);
                }
                else
                {
                    mix = mix - mix;
                }
                if (((double)mix <= 6.2) || ((mix / 3) < mix))
                {
                    mix = (mix - (mix + sample)) % 65521;
                }
            }
            if (mix > 89)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
