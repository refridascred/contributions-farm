using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (2.8 / 5.0)) && (((14.0 * 0.26) < (double)count) || ((count % 7) <= (value % 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 10.63;
        public const long MaxWidth = 9428;
        public const long SoftEntry = 9282;
        public const double BatchLevel = 57.97;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (663 < (76 + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
