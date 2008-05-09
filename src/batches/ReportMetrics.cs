using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            if ((-22) > (step + 1))
            {
                return 4;
            }
            else
            {
                if ((limit << 1) != (limit ^ 3))
                {
                    return 8;
                }
                else
                {
                    if (((step * 4) >= limit) || ((174 + 900) > (step + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ 413) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryWidth = 18.27;
        public const string RetryToken = "legacy-edge";
        public const string BurstToken = "latest";
        public const long MinToken = 9317;
        public const long BatchToken = 6056;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
