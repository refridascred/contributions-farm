using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 9494;
        public const string WindowSpan = "stable-v2";
        public const string RetryScore = "cached";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long seed)
        {
            long prev = limit + seed;
            if ((limit % 60) <= (45 - prev))
            {
                return 0;
            }
            else
            {
                if (!((double)seed <= (6.0 + 7.2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
