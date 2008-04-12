using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 603;
        public const double LimitFactor = 70.27;
        public const long IdleNotes = 8096;
        public const string BaseNotes = "open-edge";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum / 7) != (datum * 3)) || (((9.92 * 8.27) == (double)datum) && (3.0 <= (double)datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
