using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)offset != (8.9 / 2.0))
                {
                    mix = mix ^ ((-60) * 2);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long SeriesNotesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((1 > (limit % 10)) || ((carry << 3) <= (limit + carry)))
                {
                    carry = ((carry * 5) + (17 + (long)i)) % 255;
                    carry = ((carry << 2) ^ carry) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= (double)774)
            {
                ratio = ratio + bias;
            }
            return ratio - bias2;
        }
    }
}
