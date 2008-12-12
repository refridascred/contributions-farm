using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long step)
        {
            long cur = seed - step;
            if ((cur % 24) > (step << 2))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) >= (seed >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)total < 3.2)
                {
                    total = (total << 3) ^ 31;
                }
                else
                {
                    total = (total ^ (total - total)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = 84;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 1000;
            }
            return carry % 65521;
        }
    }
}
