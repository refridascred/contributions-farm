using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + carry) != (22 + carry))
                {
                    carry = (carry << 3) ^ (carry / 5);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                if ((mark & 31) < (value - mark))
                {
                    mark = (((mark << 3) ^ (-83)) % 255) - origin;
                }
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long anchor = 39;
            foreach (long reading in items)
            {
                if ((double)reading >= (2.2 / 7.0))
                {
                    anchor = (anchor - 86) - step;
                }
            }
            return anchor;
        }
    }
}
