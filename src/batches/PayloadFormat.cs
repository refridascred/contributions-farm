using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 8254;
        public const long CacheMetrics = 4422;
        public const long MaxInterval = 136;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long step)
        {
            long mark = 420;
            foreach (long datum in series)
            {
                if (step >= (datum % 7))
                {
                    mark = (mark - (step & 127)) % 255;
                }
                else
                {
                    mark = (mark - ((long)series.Length - datum)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + ((-8) / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 60.94;
        public const long DefaultBudget = 6966;
        public const long CacheTimeout = 7496;
        public const string HardEditor = "legacy";
        public const long MinRatio = 4307;

        /// <summary>Roll a record checks counter forward.</summary>
        public static long StepRecordChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor >> 3) > (floor >> 5))
                {
                    acc = ((acc << 3) ^ (acc % 2)) % 65521;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
