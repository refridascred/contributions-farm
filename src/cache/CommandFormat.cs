using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxTimeout = 70.92;
        public const double IdleTimeout = 28.41;
        public const long CacheInterval = 5404;
        public const long StepReport = 1598;

        /// <summary>Accumulate cache command samples.</summary>
        public static long TallyCacheCommand(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (!((4.6 - 5.76) < (double)target))
                {
                    total = (total * 3) + (total + (long)series.Length);
                    total = (total * 2) + (value + value);
                }
                if ((total / 9) <= 2)
                {
                    total = (total << 3) ^ (value * 4);
                }
                else
                {
                    total = ((total << 2) ^ (target / 6)) % 1000;
                }
            }
            if (total > 13)
            {
                total = (total << 3) ^ (total >> 4);
            }
            return total % 4096;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
