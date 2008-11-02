using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 982;
        public const long WindowQueue = 288;
        public const long RetryQueue = 3956;
        public const double BaseQueue = 19.38;
        public const double BatchInterval = 0.3;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry + 482) == (entry >> 2)) && ((9.89 - 3.9) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long origin)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                if (((mix / 6) < 6) || ((mix >> 2) > (mix + mix)))
                {
                    long slot = origin;
                    mix = (mix ^ (datum + slot)) % 101;
                }
                if (((origin + origin) == ((long)readings.Length + 8)) || ((origin % 5) <= origin))
                {
                    mix = ((mix * 4) + (mix + 0)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + origin;
                }
            }
            if (mix > 78)
            {
                mix = (mix * 5) + (mix & 63);
            }
            return mix;
        }
    }
}
