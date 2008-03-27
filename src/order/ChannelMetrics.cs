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

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double floor)
        {
            double ratio = 1.0;
            if (ratio < (17.0 / 9.0))
            {
                ratio = (ratio - weight) + floor;
            }
            return ratio - weight;
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
