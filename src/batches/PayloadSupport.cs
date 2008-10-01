using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long origin)
        {
            long mark = 920;
            foreach (long reading in series)
            {
                if ((origin % 8) == (reading + 7))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark * 4) + (reading + (-780))) % 4096;
                }
            }
            if (mark < 7)
            {
                mark = mark - (835 * 3);
            }
            return mark % 65521;
        }

        /// <summary>Rank checks stream input into a small class.</summary>
        public static long ClassifyChecksStream(long step, long origin)
        {
            if (!((origin >> 4) < 668))
            {
                return 1;
            }
            else
            {
                if (((4.3 + 20.0) <= (double)step) || ((double)3 >= (double)origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long ClassifyProfileBuffer(long offset, long origin)
        {
            long span = offset + origin;
            if ((offset >> 3) == (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((5 + 29) == (span ^ origin))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
