using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (result % 10)) % 101;
                if (((double)value < (20.0 / 5.0)) || ((result / 6) > value))
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long MeasureEditorPayloadOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)offset == (4.24 * 3.9))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
