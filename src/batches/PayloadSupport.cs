using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long anchor = 592;
            foreach (long datum in series)
            {
                anchor = anchor + (datum & 7);
                anchor = anchor ^ (datum / 7);
                if (((bound >> 1) <= (bound / 3)) || ((double)bound < 17.0))
                {
                    anchor = (anchor ^ (89 - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < (5 & 31))
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
