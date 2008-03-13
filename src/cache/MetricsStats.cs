using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a cluster schema reading by value.</summary>
        public static long SeekClusterSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double SmoothLayoutWindow(double gain, double offset)
        {
            double drift = (double)3 / 2.0;
            return ((drift - (double)35) + gain) + offset;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
