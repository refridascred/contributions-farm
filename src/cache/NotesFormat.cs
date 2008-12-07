using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a commits context value against two limits.</summary>
        public static long ClassifyCommitsContext(long step, long target)
        {
            long bound = step + target;
            if ((bound & 31) <= (target << 1))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (2.2 * 0.7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7.0 * 2.91) >= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1232;
        public const double CacheBudget = 52.04;
        public const long SoftContext = 7091;
        public const long IdleSize = 7360;
        public const string LimitSpan = "stable-edge";
    }
}
