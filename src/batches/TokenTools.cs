using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next metric already value from a seed.</summary>
        public static long SeriesMetricAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (5 + target)) % 101) ^ (long)i2;
                    mark = ((mark << 3) ^ (mark << 3)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            long step = offset - seed;
            if (seed < (step + offset))
            {
                return 5;
            }
            else
            {
                if (((step ^ seed) == (step + 98)) || ((seed * 2) < (step & 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double load = 4.0;
            if (load <= (double)2)
            {
                load = load - (double)732;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (rate - load)) + (double)(long)i;
            }
            return load + (load + span);
        }
    }
}
