using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (!(sample > (result % 100)))
                {
                    result = (result + (sample % 12)) % 65521;
                }
            }
            if (result < 68)
            {
                result = (result ^ (result >> 1)) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (floor * 8.7) * 9.1;
            return (load + load) + rate;
        }
    }
}
