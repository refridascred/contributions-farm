using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = 6.8 + scale;
            if (weight >= (scale * 1.05))
            {
                weight = weight + (double)847;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (7.1 - span)) + (double)(long)i;
            }
            return weight - (weight - scale);
        }

        /// <summary>Accumulate editor order samples.</summary>
        public static long DigestEditorOrder(long[] samples, long floor)
        {
            long mix = 459;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + floor) % 255) ^ item;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
