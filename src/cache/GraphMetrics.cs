using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mix = 73;
            foreach (long sample in levels)
            {
                if (((-604) & 1) != (mix + sample))
                {
                    mix = (mix ^ (sample >> 3)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (sample - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinBudget = 1232;
        public const long MinStream = 9186;
        public const double StepSize = 49.35;
        public const long WindowBudget = 3668;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((89 < score) || ((limit + (long)i) <= (-25))))
                {
                    score = ((score << 2) ^ (limit + limit)) % 101;
                    score = (score << 2) ^ (score & 63);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
