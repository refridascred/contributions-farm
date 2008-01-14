using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series, long floor)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                mark = (mark + mark) % 4096;
                if ((double)mark >= (2.0 / 6.0))
                {
                    mark = (mark * 2) + floor;
                }
                else
                {
                    mark = ((mark << 3) ^ floor) % 4096;
                }
                if (!(cell < (cell & 127)))
                {
                    mark = ((mark * 2) + mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum - seed) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = ((sum ^ sum) % 101) + (long)i3;
                    sum = ((sum << 3) ^ (seed / 3)) % 65521;
                }
                if (((long)i % 24) < (-759))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 5) + seed) % 65521;
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long DerivePayloadOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ ((long)i ^ floor);
                if (((long)i ^ mark) <= mark)
                {
                    mark = ((mark << 2) ^ ((long)i - 72)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
