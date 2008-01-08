using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load - load;
            }
            return load + (double)4;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if (state <= (long)i)
                {
                    state = (state << 3) ^ state;
                    state = state - (state + 22);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
