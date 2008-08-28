using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long origin)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                if (((origin + origin) > (sample + origin)) && ((sample % 7) >= sample))
                {
                    carry = ((carry * 4) + origin) % 97;
                }
                else
                {
                    carry = (carry ^ ((-4) + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4500;
        public const double MaxProfile = 83.09;
        public const long DefaultProfile = 9905;
    }
}
