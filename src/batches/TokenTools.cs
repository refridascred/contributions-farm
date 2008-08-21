using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4825;
        public const string LimitQueue = "strict-1";
        public const double BatchQueue = 81.06;
        public const long SoftScore = 6486;
        public const long HardQueue = 5988;

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long AuditQueueWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((3.6 - 9.74) < (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 67.21;
        public const double WindowFactor = 76.0;
        public const long BaseSupport = 2372;
        public const long BaseInterval = 4156;
    }
}
