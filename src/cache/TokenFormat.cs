using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                if ((long)series.Length != (anchor + 535))
                {
                    anchor = (((anchor << 3) ^ anchor) % 101) + reading;
                }
            }
            if (anchor > 616)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
