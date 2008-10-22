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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if (score > ((long)i - 36))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
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
