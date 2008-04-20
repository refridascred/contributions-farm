using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] items)
        {
            long mark = -121;
            foreach (long cell in items)
            {
                if (((mark >> 3) >= cell) || ((mark + 70) > mark))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics filter readings.</summary>
        public static long DigestMetricsFilter(long[] levels, long seed)
        {
            long mark = 33;
            foreach (long entry in levels)
            {
                if ((8 + mark) == ((-188) << 1))
                {
                    mark = (mark ^ (entry * 4)) - seed;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 101;
                }
            }
            if (mark < (-9))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
