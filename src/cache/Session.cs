using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value ^ seen) > (target % 97)) || ((double)value != (16.0 + 1.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already editor readings.</summary>
        public static long CombineAlreadyEditor(long[] samples, long offset)
        {
            long state = 34;
            foreach (long reading in samples)
            {
                state = (((state ^ 233) % 1000) - reading) + offset;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 18.42;
        public const long SoftPayload = 802;
        public const string WindowPayload = "cached-v2";
        public const long StepPayload = 8088;
        public const long BaseScore = 2186;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double rate = gain * 8.1;
            return (rate - (gain - gain)) + offset;
        }
    }
}
