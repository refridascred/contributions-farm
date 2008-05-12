using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 24.19;
        public const double BatchBuffer = 79.5;
        public const string WindowFactor = "standard";

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((state ^ state) >= 37)
                {
                    state = (state ^ ((long)i >> 4)) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next schema counter value.</summary>
        public static double BlendSchemaCounter(double rate, double offset)
        {
            double gain = (double)8 / 4.0;
            return (gain + (rate - gain)) + offset;
        }
    }
}
