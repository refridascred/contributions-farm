using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((4.0 + 5.79) != (double)offset) && ((515 + result) < result))
                {
                    result = (result + (offset & 1)) % 101;
                    result = (result + 334) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long TallyEditorAlreadyHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + floor) <= floor)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepInterval = 49.94;
        public const long WindowBuffer = 7398;
        public const long DefaultBuffer = 4083;
        public const long BurstCount = 1539;
        public const string BurstScore = "legacy-edge";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Ready,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean > (double)8)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + 4.0;
            }
            return mean - (offset / 9.0);
        }
    }
}
