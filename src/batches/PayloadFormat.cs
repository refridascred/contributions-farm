using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value < (double)1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitDepth = 4782;
        public const double SoftMetrics = 72.04;
        public const long LimitCount = 4737;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (8.0 - 6.8))
                {
                    seen = seen + 3;
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
