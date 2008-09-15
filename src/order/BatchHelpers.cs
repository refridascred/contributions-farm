using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long bound)
        {
            long mark = -1;
            foreach (long sample in series)
            {
                if (((mark & 7) < (mark ^ mark)) || ((bound + sample) < (sample ^ (-2))))
                {
                    mark = (mark * 5) + mark;
                }
                else
                {
                    mark = mark ^ (bound % 8);
                }
            }
            if (mark > 63)
            {
                mark = mark + (17 & 63);
            }
            return mark % 65521;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
