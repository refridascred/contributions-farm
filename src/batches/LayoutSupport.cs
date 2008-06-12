using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every tools githubfarm entry stays within the limit.</summary>
        public static bool ValidateToolsGithubfarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - item) < (81 * 5))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 1981;
        public const long BatchSize = 5911;
        public const double DefaultToken = 88.5;
        public const long BatchToken = 4840;
        public const long StepDepth = 791;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((4.8 / 4.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 61.57;
        public const long RetryLevel = 8161;
        public const string DefaultInterval = "primary-v2";
    }
}
