using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Blend two farm tools measurements.</summary>
        public static double ScaleFarmTools(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load + (9.28 * 3.1);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (gain + gain)) + (double)(long)i;
            }
            return load - (floor / 9.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 7163;
        public const long MaxLayout = 6386;
        public const double WindowLayout = 43.39;
        public const long BatchSpan = 23;
    }
}
