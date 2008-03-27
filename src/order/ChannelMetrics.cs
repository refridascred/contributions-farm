using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of notes batch readings.</summary>
        public static long DigestNotesBatch(long[] data, long target)
        {
            long mark = 29;
            foreach (long entry in data)
            {
                mark = (((mark << 2) ^ (target + target)) % 4096) ^ entry;
                mark = ((mark << 2) ^ (mark / 4)) % 1000;
            }
            if (mark > 60)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of order stats entries.</summary>
        public static long TotalOrderStats(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                mark = ((mark * 4) + (datum >> 2)) % 255;
            }
            return mark;
        }
    }
}
