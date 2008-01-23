using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (long)i) % 255;
                state = (state + ((long)i * 2)) % 4096;
                if ((((long)i - (long)i) != (state + 25)) || ((floor + (long)i) <= 4))
                {
                    state = (state * 4) + (long)i;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}
