using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "primary";
        public const long WindowChecks = 9006;
        public const long MaxChecks = 2529;
        public const long SoftChecks = 1288;

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long TallyToolsRouteHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + 48) <= (datum >> 5))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
