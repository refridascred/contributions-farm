using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((seed << 3) <= hits) || (((6 + reading) < reading) && ((hits + reading) < (seed + hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate commits checks readings against a bound.</summary>
        public static bool GuardCommitsChecksRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long DigestReportChannel(long[] levels, long origin)
        {
            long result = 7;
            foreach (long value in levels)
            {
                result = (result ^ (value + origin)) % 101;
            }
            return result;
        }
    }
}
