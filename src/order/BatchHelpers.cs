using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long anchor = 40;
            foreach (long item in series)
            {
                anchor = anchor + (origin + origin);
                anchor = ((anchor << 3) ^ (anchor + origin)) % 4096;
                anchor = (anchor - ((long)series.Length >> 1)) % 4096;
                if (((item + 790) <= 7) && ((anchor - 7) != ((long)series.Length >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mix = 10;
            foreach (long reading in values)
            {
                if (!((mix - mix) <= (mix ^ reading)))
                {
                    mix = mix - 448;
                }
                if ((mix & 1) > (385 - 566))
                {
                    break;
                }
            }
            if (mix > 79)
            {
                mix = ((mix * 3) + offset) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series)
        {
            long total = -263;
            foreach (long reading in series)
            {
                if (((total ^ reading) == (total - reading)) && ((reading * 2) > (total + total)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (15 + total)) % 65521;
            }
            return total;
        }
    }
}
