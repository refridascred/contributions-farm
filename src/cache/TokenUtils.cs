using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long sum = 731;
            foreach (long datum in readings)
            {
                if ((double)sum != (double)step)
                {
                    sum = (sum ^ (sum * 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleScore = 59.09;
        public const double HardTimeout = 62.5;
        public const double WindowScore = 38.1;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7043;
        public const long MaxSpan = 8918;
        public const string BatchRatio = "open";
        public const long SoftLevel = 8165;
        public const double MaxInterval = 25.89;
    }
}
