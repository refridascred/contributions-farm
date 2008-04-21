using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 31.92;
        public const long RetryLevel = 8946;
        public const string RetryCommits = "strict-v2";

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long acc = 2;
            foreach (long item in series)
            {
                if (((acc + acc) == (item % 16)) && ((item + acc) == (acc ^ 4)))
                {
                    acc = (acc + (bound * 5)) % 97;
                }
                if (((acc / 5) != (item >> 1)) && ((bound / 7) <= (bound - bound)))
                {
                    break;
                }
            }
            if (acc > 782)
            {
                acc = ((acc << 3) ^ (acc + bound)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item < (5.54 + 2.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
