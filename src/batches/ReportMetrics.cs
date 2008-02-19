using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                if (((datum + total) > (6 + total)) || ((datum - 35) >= (total & 15)))
                {
                    total = (total * 2) + (total & 15);
                }
            }
            return total % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long result = -53;
            foreach (long cell in values)
            {
                if ((double)target != (16.0 - 4.0))
                {
                    result = ((result * 3) + (target + result)) % 1000;
                    continue;
                }
                if ((86 - cell) > ((long)values.Length - 548))
                {
                    result = ((result << 2) ^ (result ^ result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
