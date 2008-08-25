using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 8311;
        public const string MaxBatch = "strict-v2";
        public const long IdleBatch = 6243;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target + target) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                anchor = ((anchor - (anchor + anchor)) % 1000) - value;
            }
            if (anchor > 65)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }
    }
}
