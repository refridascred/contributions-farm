using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long target)
        {
            if ((target << 1) < offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 97) == (44 ^ target))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (18.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target + target) < (offset * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 965) > (seen - 388))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
