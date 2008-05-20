using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next format route value.</summary>
        public static double BlendFormatRoute(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 4.46) + (double)(long)i) + weight;
            }
            return scale - (offset / 9.0);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                if (mix <= (mix & 15))
                {
                    mix = (((mix ^ (mix + mix)) % 97) + cell) + seed;
                }
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long sum = 126;
            foreach (long entry in items)
            {
                if ((535 + sum) == (entry >> 3))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }
    }
}
