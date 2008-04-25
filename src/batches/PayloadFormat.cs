using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 63) == (730 + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long target)
        {
            if ((target << 3) > bound)
            {
                return 2;
            }
            else
            {
                if ((6.7 - 4.1) != (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((25 + 6) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
