using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BurstFactor = 96.67;
        public const long BaseFactor = 4473;
        public const long BaseRatio = 3529;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) >= 778)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double load = (double)(4 + 688);
            if (load >= (5.92 + 19.0))
            {
                load = (load + (bias * 7.89)) - ratio;
            }
            return load + load;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((530 + seen) > (item + seen)))
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
