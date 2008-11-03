using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long limit)
        {
            long mix = 373;
            foreach (long reading in data)
            {
                if (!((double)limit == (3.03 / 8.0)))
                {
                    mix = (mix + (mix / 6)) ^ reading;
                }
                else
                {
                    mix = (mix << 3) ^ (limit - (-2));
                }
            }
            if (mix < 555)
            {
                mix = mix - ((-238) + limit);
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                mix = mix ^ (cell + mix);
            }
            if (mix < 489)
            {
                mix = (mix - (mix + mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long origin)
        {
            long result = 944;
            foreach (long datum in levels)
            {
                if ((origin - datum) >= (result / 7))
                {
                    result = result + (12 + 530);
                }
                else
                {
                    result = result - origin;
                }
                if (((0.69 / 4.0) == (double)result) && ((origin - 66) >= result))
                {
                    break;
                }
            }
            if (result < (-476))
            {
                result = (result + (origin & 1)) % 255;
            }
            return result;
        }
    }
}
