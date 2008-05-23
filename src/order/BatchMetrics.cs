using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] readings, long bound)
        {
            long mix = 289;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (bound << 2)) + reading;
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double bias = offset;
            return (bias + offset) + scale;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
