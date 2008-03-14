using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (offset3 < (offset3 >> 1))
            {
                return 3;
            }
            else
            {
                if (((1.85 * 17.0) <= (2.0 + 4.73)) && ((double)offset2 != (double)35))
                {
                    return 5;
                }
                else
                {
                    if ((1.82 + 3.5) <= (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset3 - offset2) > (4 ^ 858))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 9417;
        public const string RetryCount = "fallback-v2";
        public const double BatchContributi = 29.63;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long CountBufferFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + step) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 6137;
        public const double StepScore = 13.87;
        public const long BatchDepth = 9528;
    }
}
