using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + step;
                if ((step % 97) < (step + acc))
                {
                    acc = (acc ^ 8) % 101;
                    acc = (acc + (acc - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long bound)
        {
            long sum = 874;
            foreach (long sample in values)
            {
                sum = ((sum + sum) % 4096) - sample;
                if ((double)sum <= (9.2 / 7.0))
                {
                    sum = sum + sum;
                }
            }
            if (sum < 27)
            {
                sum = (sum + bound) % 101;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
