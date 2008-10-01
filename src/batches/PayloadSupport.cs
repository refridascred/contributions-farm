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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
