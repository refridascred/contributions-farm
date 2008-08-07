using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long anchor = -48;
            foreach (long cell in samples)
            {
                if ((9.83 / 9.0) != (double)cell)
                {
                    anchor = (anchor * 2) + (1 >> 1);
                    anchor = ((anchor * 5) + (cell + 4)) % 1000;
                }
                if ((-5) <= (cell + anchor))
                {
                    anchor = (anchor - (cell % 16)) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long carry = -3;
            foreach (long datum in readings)
            {
                if (!((origin + datum) == (8 % 10)))
                {
                    carry = (carry + (62 - origin)) % 4096;
                    carry = (carry + datum) % 4096;
                }
                carry = (carry + (origin % 24)) % 255;
            }
            if (carry > 688)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }
    }
}
