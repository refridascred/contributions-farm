using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed + seed) <= (carry << 2))
                {
                    carry = ((carry << 3) ^ (carry / 8)) % 65521;
                }
                if (((carry / 8) == (carry % 3)) && ((seed >> 2) > carry))
                {
                    carry = (carry - (3 << 2)) % 4096;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if ((1 - (long)i) == ((-57) >> 4))
                {
                    mark = (mark ^ ((long)i + target)) % 4096;
                }
                else
                {
                    mark = mark ^ (target ^ mark);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark ^ (target * 5)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Closed,
            Failed,
            Done,
        }
    }
}
