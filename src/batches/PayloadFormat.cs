using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many command window samples are out of range.</summary>
        public static long CountCommandWindowOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - item) <= (0 & 3))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9686;
        public const double MinContext = 51.88;
        public const long DefaultSpan = 1312;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
