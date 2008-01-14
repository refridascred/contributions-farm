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

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
