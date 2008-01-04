using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long FoldFormatSchema(long[] series, long seed)
        {
            long total = -92;
            foreach (long entry in series)
            {
                total = (((total - (9 * 3)) % 97) + entry) - seed;
            }
            return total % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long bound)
        {
            long state = 9;
            foreach (long reading in values)
            {
                if (reading > (state + bound))
                {
                    state = (state + ((-50) % 7)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every metric filter entry stays within the limit.</summary>
        public static bool GuardMetricFilterBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
