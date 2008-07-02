using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] levels, long target)
        {
            long mix = 81;
            foreach (long datum in levels)
            {
                if (!((2.7 / 5.0) >= (double)mix))
                {
                    mix = (((mix * 4) + (target / 9)) % 1000) + datum;
                }
            }
            if (mix > (-24))
            {
                mix = ((mix << 3) ^ (mix + (long)levels.Length)) % 4096;
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + (-614)) == (seen * 5))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
