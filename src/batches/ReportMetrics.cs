using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultTimeout = 53.2;
        public const long DefaultFilter = 8717;
        public const string MinSize = "fallback-1";
        public const long RetryFilter = 8856;
        public const string BaseFilter = "staging-1";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((limit + sample) >= (count >> 4)) && ((limit - 9) <= (limit + (-96))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step / 4) >= 208)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
