using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitBudget = "latest-v2";
        public const double StepInterval = 98.44;
        public const double BaseAccount = 31.74;
        public const long BurstAccount = 3379;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + seen) <= (seen - reading))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            long edge = seed ^ step;
            if (step > (seed + 786))
            {
                return 6;
            }
            else
            {
                if ((double)edge < 9.3)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
