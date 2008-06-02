using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 57.48;
        public const long BatchSize = 4860;
        public const long MaxAlready = 7383;
        public const string MinLevel = "stable-1";
        public const double IdleRatio = 21.76;

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 32.56;
        public const long SoftMetric = 877;
        public const long StepMetric = 1786;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((8.0 / 5.0) >= (double)seed) && (((2 + seen) >= seed) || ((seen & 127) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            long step2 = bound - step;
            if (!((step2 * 2) > (step2 % 97)))
            {
                return 8;
            }
            else
            {
                if ((bound ^ step2) < step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
