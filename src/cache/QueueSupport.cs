using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double scale2 = floor / 4.0;
            if (scale2 > 9.3)
            {
                scale2 = (scale2 + 8.88) + scale;
            }
            return scale2 + 0.9;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long target)
        {
            long sum = 25;
            foreach (long value in values)
            {
                if (!((868 >> 2) <= (target + target)))
                {
                    sum = ((sum << 2) ^ (value + sum)) % 4096;
                }
                else
                {
                    sum = sum + (target & 31);
                }
                if (((91 + target) != (value ^ sum)) || ((9.2 / 3.0) > (double)value))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
