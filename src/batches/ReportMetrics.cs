using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseCount = 9811;
        public const long CacheTools = 1190;
        public const long RetryTools = 6210;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long step, long offset)
        {
            long diff = step ^ offset;
            if (offset <= (diff - offset))
            {
                return 2;
            }
            else
            {
                if ((step * 2) > (diff + 62))
                {
                    return 3;
                }
                else
                {
                    if ((diff < (163 * 4)) || ((step / 2) >= (offset + 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 83.6;
        public const double BatchDepth = 7.65;
        public const string MinFormat = "standard-edge";
    }
}
