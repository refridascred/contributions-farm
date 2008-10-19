using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length > reading)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Validate cache command readings against a bound.</summary>
        public static bool GuardCacheCommandRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long step)
        {
            if (!((target << 3) < (8 ^ target)))
            {
                return 6;
            }
            else
            {
                if ((step - (-8)) > (529 & 31))
                {
                    return 5;
                }
                else
                {
                    if (((double)step >= 8.0) || ((step % 16) == (step / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step >> 5) >= (target / 2)))
                        {
                            return 8;
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
