using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metrics githubfarm samples are out of range.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (2 <= seen)
                {
                    seen = ((seen + 1) ^ datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 8) != ((-2) << 1))
                {
                    score = (score - 42) % 65521;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
