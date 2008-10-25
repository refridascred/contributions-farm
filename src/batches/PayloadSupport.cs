using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 64.62;
        public const long MinEditor = 8206;
        public const long IdleEditor = 3971;
        public const long DefaultEditor = 9378;
        public const long SoftSpan = 718;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels, long limit)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if ((mark < (limit ^ 117)) || ((mark + mark) == ((-2) + 0)))
                {
                    mark = ((mark + (limit * 2)) % 4096) + datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale - (double)930;
            }
            return scale - bias;
        }
    }
}
