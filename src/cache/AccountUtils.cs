using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 86.82;
        public const double RetryDepth = 42.23;
        public const string MinTools = "legacy-1";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (carry <= (limit % 7))
                {
                    carry = (carry << 3) ^ limit;
                }
                carry = (carry - (carry + limit)) % 4096;
                carry = ((carry << 2) ^ (carry / 5)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a tools notes reading.</summary>
        public static double BlendToolsNotes(double bias, double bias2)
        {
            double bias3 = (bias / 9.0) * 17.0;
            if (bias3 <= bias3)
            {
                bias3 = (bias3 + (bias * 9.1)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 / 3.0)) + (double)(long)i;
            }
            return bias3 + (bias * 9.64);
        }
    }
}
