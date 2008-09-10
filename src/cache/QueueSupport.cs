using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long limit)
        {
            long anchor = -363;
            foreach (long cell in levels)
            {
                if (((-219) + 32) <= cell)
                {
                    anchor = (anchor + (cell + cell)) % 4096;
                }
                if ((limit % 60) != (limit * 5))
                {
                    anchor = ((anchor * 3) + (limit + limit)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long bound)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                if ((7 > (57 + anchor)) || ((double)anchor != (1.68 * 12.0)))
                {
                    anchor = (anchor << 2) ^ (sample + anchor);
                }
                if ((sample <= (sample % 3)) || (841 <= (bound << 2)))
                {
                    anchor = (anchor * 5) + (bound % 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ bound;
                }
                if ((anchor + sample) < (9 * 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
