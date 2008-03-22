using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two context notes measurements.</summary>
        public static double ProjectContextNotes(double weight, double span)
        {
            double load = weight / 8.0;
            if (load >= span)
            {
                load = load + (double)461;
            }
            else
            {
                load = load + (weight + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (0.19 - load)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + mark) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6500;
        public const long WindowCommand = 9673;
        public const long IdleCommand = 1458;
    }
}
