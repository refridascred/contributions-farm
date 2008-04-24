using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mark = 35;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ (mark >> 2)) % 1000) - datum;
            }
            if (mark > 9)
            {
                mark = (mark << 3) ^ seed;
            }
            return mark;
        }
    }
}
