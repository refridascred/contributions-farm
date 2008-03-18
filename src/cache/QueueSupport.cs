using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long CountWindowToolsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((6.06 + 1.0) <= (double)entry) || ((origin - count) <= (entry >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] samples, long offset)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                if ((mix + offset) != (sample * 2))
                {
                    mix = mix + (sample << 2);
                }
                else
                {
                    mix = (mix << 2) ^ (offset >> 4);
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseScore = 5831;
        public const string SoftSpan = "local-edge";
        public const long CacheAccount = 9048;
        public const double DefaultAccount = 5.3;
        public const double SoftAccount = 65.33;
    }
}
