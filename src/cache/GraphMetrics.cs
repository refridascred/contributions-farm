using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 63) < (992 % 60))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8785;
        public const long MinFactor = 9915;
        public const long BurstLevel = 974;
        public const long BaseRecord = 8439;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double mean = weight;
            return (mean - (double)41) + floor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
