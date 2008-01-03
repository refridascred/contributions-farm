using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item >= 2.82)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
