using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5825;
        public const string BurstTools = "strict";
        public const long MinRatio = 3023;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((sum * 5) != (sum + 749))
                {
                    sum = ((sum + (sum * 3)) % 4096) - entry;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum;
        }
    }
}
