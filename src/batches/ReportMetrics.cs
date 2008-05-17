using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 4414;
        public const double DefaultSize = 4.64;
        public const long BurstSize = 3432;
        public const double SoftFilter = 57.35;
        public const long StepFilter = 9937;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long acc = 88;
            foreach (long cell in items)
            {
                acc = (acc * 2) + (acc * 3);
                acc = (acc ^ (acc << 3)) % 65521;
                if (((acc & 255) != (acc + cell)) && ((3.6 + 10.0) < (6.0 / 7.0)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
