using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((carry << 2) != ((long)i << 3))
                {
                    carry = carry + (floor ^ floor);
                    carry = carry - floor;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                if (!((sample + acc) <= (acc >> 4)))
                {
                    acc = acc + acc;
                }
                if (((double)acc < (double)9) && ((sample + sample) > 4))
                {
                    acc = (acc - 744) % 4096;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            if (acc < (-621))
            {
                acc = (acc - (8 & 127)) % 65521;
            }
            return acc;
        }
    }
}
