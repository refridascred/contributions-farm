using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (20 + origin)) && (origin <= 93))
                {
                    mix = ((mix << 3) ^ (origin + mix)) % 4096;
                }
                mix = (mix * 2) + ((long)i * 4);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((102 + 28) > tally)
                {
                    tally = ((tally + 1) + datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long sum = 41;
            foreach (long item in samples)
            {
                if (((1.14 - 17.0) == (double)seed) && ((seed >> 1) != (seed - (-7))))
                {
                    sum = (sum << 2) ^ item;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ (seed - seed);
            }
            return sum;
        }
    }
}
