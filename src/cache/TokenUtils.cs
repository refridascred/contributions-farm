using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5173;
        public const double BatchWidth = 62.66;
        public const double DefaultWidth = 20.77;
        public const long StepInterval = 9245;
        public const long HardWidth = 9280;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                bool valid = (double)192 <= (double)target;
                valid = (result - 315) > result;
                if (valid)
                {
                    valid = (7.73 - 9.4) != (double)target;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a payload route value against two limits.</summary>
        public static long SortPayloadRoute(long offset, long target)
        {
            long bound = offset ^ target;
            if ((4.2 / 7.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((761 << 2) > (target - (-78)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - offset) <= (bound % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((698 & 127) < (bound ^ bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
