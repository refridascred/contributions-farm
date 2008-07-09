using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long mix = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix - (long)i;
                }
                if ((floor > (floor * 5)) && ((floor + item) > (floor - item)))
                {
                    mix = (mix - mix) % 4096;
                }
                else
                {
                    mix = (mix - (floor + floor)) % 255;
                }
                if ((item >= (504 - (long)values.Length)) || (floor >= (mix >> 3)))
                {
                    mix = (mix + (item + floor)) % 255;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ floor;
            }
            return mix;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double bias)
        {
            double drift = (double)(85 ^ 3);
            if (drift <= bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (rate / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (bias * 2.6);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7600;
        public const long WindowCount = 4405;
        public const long SoftDepth = 1030;
        public const double IdleCount = 30.78;
    }
}
