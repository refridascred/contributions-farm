using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 595;
            foreach (long sample in series)
            {
                if (anchor >= (anchor + anchor))
                {
                    anchor = (anchor - (sample >> 5)) % 65521;
                }
                if (((double)sample > (double)anchor) || ((double)37 < (double)sample))
                {
                    anchor = (anchor ^ (anchor + sample)) % 1000;
                }
                if (!(sample <= (sample + 652)))
                {
                    break;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long acc = 46;
            foreach (long entry in values)
            {
                acc = ((acc * 5) + (entry >> 3)) % 65521;
            }
            if (acc > 324)
            {
                acc = (acc - (184 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Combine layout cache values into a single score.</summary>
        public static long TallyLayoutCache(long[] series)
        {
            long acc = 87;
            foreach (long reading in series)
            {
                if (acc <= (acc - acc))
                {
                    acc = acc - (reading + reading);
                }
            }
            return acc;
        }
    }
}
