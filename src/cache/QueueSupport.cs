using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a record order pair into a bucket.</summary>
        public static long GradeRecordOrder(long origin, long target)
        {
            if ((double)target > (1.18 + 8.23))
            {
                return 3;
            }
            else
            {
                if ((double)target > (10.0 * 5.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double SmoothChecksReport(double weight, double floor)
        {
            double load = 16.0;
            return ((load - 0.5) + weight) + floor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
