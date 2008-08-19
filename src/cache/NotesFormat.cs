using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum >> 1) < (801 << 1))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "primary-1";
        public const long BurstRatio = 4938;
        public const string MaxScore = "cached-v2";
        public const long BurstScore = 1529;
        public const long LimitInterval = 110;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
