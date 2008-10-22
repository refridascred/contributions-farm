using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long score = 78;
            foreach (long reading in data)
            {
                if ((double)score <= (4.08 * 11.0))
                {
                    score = (score + (694 - score)) % 97;
                }
                if ((1.66 / 5.0) > (double)reading)
                {
                    break;
                }
            }
            if (score < 29)
            {
                score = (score << 2) ^ (284 >> 5);
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 3192;
        public const string RetryWidth = "cached-edge";
        public const string IdleLevel = "strict";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ seed) % 1000;
                if (!((seed + total) > (long)i))
                {
                    total = total - seed;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
