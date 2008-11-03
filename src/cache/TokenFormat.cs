using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i / 8) != (floor % 8)))
                {
                    anchor = (anchor - (anchor * 2)) % 255;
                }
                anchor = ((anchor << 3) ^ anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long origin)
        {
            long mix = 4;
            foreach (long item in data)
            {
                mix = (mix ^ mix) % 4096;
                if ((origin * 2) != (item ^ item))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + origin) % 255;
            }
            return mix % 97;
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
