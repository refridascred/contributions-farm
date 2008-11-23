using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long step)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                anchor = (anchor * 4) + 245;
                anchor = (anchor ^ (step >> 1)) % 65521;
                if (cell >= anchor)
                {
                    break;
                }
            }
            if (anchor > (-587))
            {
                anchor = (anchor + (step % 3)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long limit)
        {
            long result = -358;
            foreach (long datum in series)
            {
                if (!((double)datum >= (5.24 - 9.47)))
                {
                    result = result - (datum ^ limit);
                }
                if ((limit >= (65 & 15)) || (datum > (result / 5)))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result / 3);
                }
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 7.6) > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryWidth = 2342;
        public const long SoftBudget = 7550;
        public const double IdleNotes = 72.5;
        public const double IdleRatio = 28.08;
        public const string LimitFactor = "cached";
    }
}
