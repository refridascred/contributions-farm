using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 523;
        public const double LimitDepth = 49.66;
        public const string WindowScore = "stable-v2";

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double ratio = (double)((-7) & 127);
            if (ratio < ratio)
            {
                ratio = ((ratio + 8.0) + weight) + span;
            }
            return ratio - (double)(-2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 5745;
        public const long DefaultSpan = 2931;
        public const long CacheReport = 380;

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
