using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long CountBatchContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - 846) > cell)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double weight, double offset)
        {
            double scale = offset;
            if (scale > (offset + offset))
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (weight * 7.8);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank support stream input into a small class.</summary>
        public static long SortSupportStream(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 > 404)
            {
                return 1;
            }
            else
            {
                if ((span * 3) >= floor2)
                {
                    return 2;
                }
                else
                {
                    if ((5.2 < (double)span) && ((floor2 >> 5) != (span ^ 898)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.25 / 2.0) > (double)floor2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
