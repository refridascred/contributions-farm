using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double drift = (offset / 8.0) + offset;
            if (drift < (offset + ratio))
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio + offset)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1344;
        public const long SoftContributi = 701;
        public const long StepContributi = 9796;

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                if (2.0 < (double)reading)
                {
                    mix = ((mix - (mix * 4)) % 4096) + step;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix;
        }
    }
}
