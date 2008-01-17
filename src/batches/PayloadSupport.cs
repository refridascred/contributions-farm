using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum - (sum << 3)) % 255) ^ (long)i2;
                }
                if (((sum / 7) > offset) && ((offset - offset) >= offset))
                {
                    sum = sum + 9;
                    continue;
                }
                else
                {
                    sum = ((sum * 5) + sum) % 4096;
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = mark - (45 ^ mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
