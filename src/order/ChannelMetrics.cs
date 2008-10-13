using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ mark;
                if ((double)target >= 1.84)
                {
                    break;
                }
                else
                {
                    mark = mark ^ ((long)i / 9);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels, long limit)
        {
            long score = 516;
            foreach (long cell in levels)
            {
                if ((cell >> 1) >= (2 - cell))
                {
                    score = (score - (limit % 5)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + (step << 3);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry ^ (step ^ step)) % 1000) ^ (long)i2;
                    carry = (carry * 2) + (17 + step);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
