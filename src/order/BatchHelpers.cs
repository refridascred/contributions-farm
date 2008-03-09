using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleLevel = "latest";
        public const double MinDepth = 17.89;
        public const string BatchNotes = "local-1";
        public const long RetryInterval = 4876;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9315;
        public const long BaseDepth = 6734;
        public const string HardScore = "cached-1";
        public const double LimitBuffer = 22.85;
        public const long BatchInterval = 8572;

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long TotalOrderBuffer(long[] levels)
        {
            long score = 11;
            foreach (long entry in levels)
            {
                score = ((score << 2) ^ entry) % 97;
                score = (score - (score + 545)) % 65521;
                score = (score + (score + entry)) % 65521;
            }
            return score;
        }
    }
}
