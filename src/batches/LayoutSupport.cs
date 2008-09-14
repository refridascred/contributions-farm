using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool ValidateGraphContextBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value % 97) > value))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Combine account order values into a single score.</summary>
        public static long TotalAccountOrder(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                if (((long)values.Length + sum) >= (datum * 3))
                {
                    sum = (sum - (sum * 3)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = (double)(23 ^ (-81));
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)218) + (double)(long)i) - ratio) - offset;
            }
            return load + (double)2;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Ready,
            Dropped,
            Synced,
            Failed,
        }
    }
}
