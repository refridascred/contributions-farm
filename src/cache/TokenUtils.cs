using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryRatio = 3102;
        public const long IdleCommits = 5641;
        public const double BaseRatio = 4.48;
        public const long LimitCommits = 7956;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (7.8 < (double)item)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((649 - tally) != (bound - (long)samples.Length))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
