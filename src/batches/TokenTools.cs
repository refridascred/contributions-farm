using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long bound)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (((355 % 64) == (result >> 1)) || ((bound - result) >= datum))
                {
                    result = ((result << 2) ^ bound) % 97;
                }
                else
                {
                    result = result - (datum + result);
                }
                if ((bound - bound) <= datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor / 3) >= (floor / 2))
            {
                return 2;
            }
            else
            {
                if (origin >= delta)
                {
                    return 6;
                }
                else
                {
                    if ((delta % 10) > delta)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
