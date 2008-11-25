using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((2.7 * 5.98) < (double)sample) || ((sample % 97) != (floor - 943))) && ((matches & 127) >= (3 - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel session entry stays within the limit.</summary>
        public static bool VerifyChannelSessionLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long total = -2;
            foreach (long item in samples)
            {
                if ((item + target) >= (target / 3))
                {
                    total = (total - (item + 0)) % 255;
                }
            }
            if (total < 606)
            {
                total = total - (total ^ target);
            }
            return total;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long AuditCacheStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((14.0 * 1.3) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
