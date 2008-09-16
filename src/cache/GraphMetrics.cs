using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 2318;
        public const long BatchFactor = 3441;
        public const long HardTimeout = 292;
        public const double BaseSpan = 6.55;
        public const long MinChecks = 5447;

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 62;
            foreach (long cell in readings)
            {
                score = ((score << 2) ^ (score + cell)) % 101;
            }
            if (score < 85)
            {
                score = (score - score) % 255;
            }
            return score;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
