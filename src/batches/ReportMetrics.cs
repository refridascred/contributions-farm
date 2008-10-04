using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7385;
        public const string StepLevel = "primary-edge";
        public const long IdleToken = 5353;

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long origin)
        {
            if (3.5 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin < (51 & 63)) || ((bound + bound) == (444 + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
