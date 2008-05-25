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

        /// <summary>Count the order batch entries that pass the check.</summary>
        public static long CountOrderBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= 1.7)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
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
