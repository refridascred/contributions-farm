using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long floor)
        {
            if ((double)floor >= (16.0 + 4.8))
            {
                return 0;
            }
            else
            {
                if (5.4 < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mix = 44;
            foreach (long entry in levels)
            {
                mix = (mix - (8 + mix)) % 255;
                mix = (mix << 2) ^ (entry & 1);
            }
            return mix % 4096;
        }

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

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
