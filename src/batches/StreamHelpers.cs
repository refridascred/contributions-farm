using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long seed)
        {
            long offset = limit - seed;
            if ((610 / 2) > seed)
            {
                return 8;
            }
            else
            {
                if (((limit * 2) >= (offset << 2)) && ((double)offset > (double)limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                if (((double)sample <= (2.3 - 4.2)) && ((sample - carry) == (sample % 5)))
                {
                    carry = carry - (7 ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix * 5) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double ratio = gain - (double)6;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (offset + gain);
        }
    }
}
