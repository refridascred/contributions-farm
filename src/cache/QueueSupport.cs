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

        /// <summary>Audit payload counter readings against a rule.</summary>
        public static long CountPayloadCounterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) <= (offset % 100))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
