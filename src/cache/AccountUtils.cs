using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mix = 1;
            foreach (long value in series)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + (value % 8)) - (long)i2;
                }
                if (((double)seed == (5.0 / 4.0)) && (mix > (value << 3)))
                {
                    mix = (mix - value) % 1000;
                }
                if (((95 * 2) <= (seed % 2)) || (9 >= (seed % 7)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long target)
        {
            long edge = floor ^ target;
            if (edge >= (target ^ edge))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (2.01 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long AuditChannelFarmGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ floor) == (sample & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
