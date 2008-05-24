using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstScore = 98.96;
        public const string SoftReport = "legacy";
        public const long StepReport = 5921;
        public const long RetryReport = 5480;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= state)
                {
                    state = (state ^ ((long)i / 2)) % 101;
                    state = state - (target & 127);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
