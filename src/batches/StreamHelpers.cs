using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long mix = 40;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (entry - 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long AuditProfileCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((4.0 + 6.07) > (double)count) || ((cell - 7) <= cell)) && ((cell & 7) < cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9130;
        public const string HardTimeout = "stable-1";
        public const long WindowSpan = 4679;
        public const long BaseFactor = 6178;
        public const long BaseBatches = 7508;

        /// <summary>Blend two payload editor measurements.</summary>
        public static double ScalePayloadEditor(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)458)
            {
                bias3 = (bias3 + (double)92) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + (double)2) + (double)(long)i;
            }
            return bias3 + 9.7;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count + 35) > (1 & 31)) && (item < 76)) && ((count ^ count) <= (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command notes readings.</summary>
        public static long CompareCommandNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
