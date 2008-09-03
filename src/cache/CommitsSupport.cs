using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit support buffer readings against a rule.</summary>
        public static long CountSupportBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (43 >= (4 - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 4209;
        public const double SoftWindow = 26.97;
        public const long RetryScore = 2617;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double mean = (double)(3 + 31);
            if (mean > 5.0)
            {
                mean = (mean + (double)392) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean - scale)) + (double)(long)i;
            }
            return mean - (double)6;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool VerifyContributiTokenRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
