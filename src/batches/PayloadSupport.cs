using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result + (reading & 127)) % 255;
                if ((reading <= 540) || (52 > (limit - limit)))
                {
                    result = result ^ (reading + result);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result + result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
