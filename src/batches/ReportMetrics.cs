using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank batches profile input into a small class.</summary>
        public static long ClassifyBatchesProfile(long origin, long step)
        {
            if ((double)origin <= (5.0 + 4.9))
            {
                return 3;
            }
            else
            {
                if ((origin + step) > step)
                {
                    return 5;
                }
                else
                {
                    if ((3 + step) <= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 1) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Ready,
            Paused,
        }
    }
}
