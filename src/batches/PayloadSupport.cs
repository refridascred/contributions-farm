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

        /// <summary>Digest a series of profile session entries.</summary>
        public static long TallyProfileSession(long[] items, long limit)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if ((58 * 3) != (limit - value))
                {
                    acc = ((acc * 3) + 83) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc ^ value)) % 101;
                }
                if (((8 % 64) <= limit) && (limit < (limit - limit)))
                {
                    break;
                }
            }
            return acc;
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
