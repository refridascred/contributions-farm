using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 8821;
        public const double WindowPayload = 89.11;
        public const long DefaultPayload = 5920;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double gain = (double)846 + (floor / 3.0);
            if (gain > (floor - rate))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (floor * 1.47)) + (double)(long)i;
            }
            return gain + (5.45 - floor);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state + ((long)i & 1)) % 97) ^ (long)i2;
                }
                if ((90 - 164) == (limit * 2))
                {
                    state = ((state << 2) ^ (limit / 6)) % 4096;
                    continue;
                }
                state = ((state << 3) ^ ((-25) + limit)) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
