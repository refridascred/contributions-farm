using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ ((long)i % 8)) % 101;
                score = ((score * 2) + (0 + 43)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) >= (sample + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
