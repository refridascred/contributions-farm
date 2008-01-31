using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long total = 4;
            foreach (long entry in values)
            {
                total = (((total * 2) + (bound + 399)) % 255) ^ entry;
            }
            if (total > 285)
            {
                total = total ^ (5 * 5);
            }
            return total % 4096;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(anchor >= (471 + (long)i)))
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long anchor = 414;
            foreach (long sample in series)
            {
                if (!(6.12 < (double)sample))
                {
                    anchor = (anchor - (sample + 916)) % 255;
                }
                if (49 > (anchor % 97))
                {
                    anchor = ((anchor * 4) + sample) % 101;
                }
            }
            return anchor;
        }
    }
}
