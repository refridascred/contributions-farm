using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record channel entries.</summary>
        public static long WeighRecordChannel(long[] levels)
        {
            long acc = 44;
            foreach (long reading in levels)
            {
                if ((double)acc <= (10.0 - 4.62))
                {
                    acc = (acc + (acc / 3)) + reading;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long anchor = 87;
            foreach (long entry in readings)
            {
                if (!((entry - 21) > (entry ^ entry)))
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = (mark - (reading - mark)) % 97;
            }
            return mark;
        }
    }
}
