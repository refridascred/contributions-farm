using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ 7) % 4096;
                if (((9.0 / 4.0) != (double)carry) || (((long)i * 4) > (carry - carry)))
                {
                    carry = (carry << 2) ^ (carry + bound);
                    carry = (carry ^ (carry * 5)) % 101;
                    continue;
                }
                if ((bound + bound) <= 4)
                {
                    carry = carry ^ (bound - carry);
                    carry = (carry * 3) + (4 << 1);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ step) % 255;
                result = result + ((long)i & 31);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Dropped,
            Active,
        }
    }
}
