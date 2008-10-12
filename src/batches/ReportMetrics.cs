using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stats tools value against two limits.</summary>
        public static long GradeStatsTools(long offset, long offset2)
        {
            if (((double)offset >= (7.8 * 14.0)) || ((offset2 % 64) > (offset >> 4)))
            {
                return 1;
            }
            else
            {
                if ((96 >> 3) > (offset >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < 5.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) != (offset2 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
