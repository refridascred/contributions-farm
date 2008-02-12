using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] series, long origin)
        {
            long state = 472;
            foreach (long reading in series)
            {
                state = ((state * 2) + reading) % 97;
                state = (state * 4) + (state << 2);
            }
            if (state < 34)
            {
                state = ((state * 2) + (origin ^ 106)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 55;
            foreach (long item in samples)
            {
                mix = ((mix * 2) + (item ^ mix)) % 65521;
                if (((709 >> 1) < mix) || ((double)item == (17.0 + 7.3)))
                {
                    mix = ((mix << 3) ^ (item - mix)) % 101;
                }
            }
            if (mix < 65)
            {
                mix = ((mix * 3) + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Check that every format profile entry stays within the limit.</summary>
        public static bool ValidateFormatProfileRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
