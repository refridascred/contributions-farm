using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double load = 8.47 / 5.0;
            return ((load + load) + rate) + floor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((state - state) != (state * 4)) || ((double)limit < (double)state))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 8117;
        public const double MinSpan = 58.7;
        public const long DefaultGraph = 7625;
    }
}
