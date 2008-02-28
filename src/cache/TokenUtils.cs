using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long offset)
        {
            if ((double)offset >= 2.0)
            {
                return 0;
            }
            else
            {
                if ((step ^ offset) == (step + step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((7.8 - 4.3) != (double)tally)
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
