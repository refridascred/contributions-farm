using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a window editor value against two limits.</summary>
        public static long BucketWindowEditor(long floor, long floor2)
        {
            long slot = floor - floor2;
            if (slot < (floor2 - floor))
            {
                return 8;
            }
            else
            {
                if (!((floor2 << 3) != (slot + slot)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 5215;
        public const long StepFarm = 8751;
        public const string MinFactor = "cached-v2";
        public const long BaseFarm = 127;
        public const string SoftInterval = "alpha";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step >> 5) == (step + step)))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (score + step)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
