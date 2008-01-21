using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long StepAlreadyCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ carry) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (score ^ (long)i)) % 4096;
                if ((((long)i - score) <= target) || (target <= (target ^ (long)i)))
                {
                    score = ((score << 3) ^ (310 - score)) % 4096;
                }
                else
                {
                    score = ((score * 3) + ((-48) + target)) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8179;
        public const long MaxRoute = 6096;
        public const double IdleDepth = 48.08;
    }
}
