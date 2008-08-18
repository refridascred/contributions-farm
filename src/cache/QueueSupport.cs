using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowRatio = "local-edge";
        public const long IdleScore = 6185;
        public const long CacheScore = 7408;
        public const long LimitCount = 307;
        public const long IdleFactor = 769;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8689;
        public const long BurstToken = 9872;
        public const long BaseRatio = 2573;
        public const double HardCount = 92.16;

        /// <summary>Audit contributi stats readings against a rule.</summary>
        public static long CountContributiStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (428 & 31))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
