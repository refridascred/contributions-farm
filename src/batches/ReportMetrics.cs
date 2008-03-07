using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long anchor = 165;
            foreach (long entry in values)
            {
                if ((seed ^ entry) >= entry)
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = anchor - (seed + seed);
                    anchor = ((anchor * 4) + (anchor & 1)) % 97;
                }
                if (anchor > (seed * 5))
                {
                    anchor = (anchor << 2) ^ (62 % 7);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool ValidateAccountWindowLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long CombineStatsReport(long[] samples, long limit)
        {
            long result = 38;
            foreach (long value in samples)
            {
                result = (result + (limit + value)) % 65521;
                if ((16.0 + 8.0) > (double)limit)
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (result + 3)) % 255;
            }
            return result;
        }
    }
}
