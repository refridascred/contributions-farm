using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 6) >= (entry % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 7.8) || (((double)cell == (5.6 * 1.12)) || ((89 ^ 1) < cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
