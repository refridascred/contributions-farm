using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double weight = (bias / 3.0) + (double)58;
            if (weight > (double)120)
            {
                weight = (weight - bias) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight * 3.57)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((13.0 - 9.63) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-99)) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 249;
        public const string CacheToken = "stable";
        public const long CacheLevel = 634;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
