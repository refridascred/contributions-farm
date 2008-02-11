using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinDepth = 3180;
        public const double IdleDepth = 45.84;
        public const long BaseCount = 4602;
        public const long BurstWidth = 1319;
        public const string CacheBudget = "open-1";

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data)
        {
            long score = 9;
            foreach (long entry in data)
            {
                score = (score << 3) ^ 782;
                score = ((score * 3) + (score % 60)) % 255;
                if ((entry - entry) >= (1 * 5))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }
    }
}
