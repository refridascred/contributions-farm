using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double load = (offset + offset) / 4.0;
            if (load < (bias - 1.0))
            {
                load = load + (double)251;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (offset / 3.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 5237;
        public const long IdleToken = 1318;
        public const long WindowBudget = 3285;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            if (floor >= (floor - floor))
            {
                return 2;
            }
            else
            {
                if (((60 / 2) <= (bound * 4)) && ((bound + floor) != (floor % 24)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if ((1.53 - 1.0) != (double)sum)
                {
                    sum = (sum - (datum % 5)) % 255;
                }
            }
            return sum;
        }
    }
}
