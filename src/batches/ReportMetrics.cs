using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long step)
        {
            long gap = seed ^ step;
            if ((seed >> 2) > (83 - gap))
            {
                return 2;
            }
            else
            {
                if (!((7 & 7) >= (7 ^ gap)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)seed != (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
