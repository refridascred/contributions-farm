using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = ((sum - sum) ^ datum) - offset;
            }
            if (sum > 591)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long floor)
        {
            long sum = 31;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((((sum * 2) + (floor + floor)) % 97) + (long)i) - entry;
                }
                if (sum >= (floor << 2))
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = sum - (sum + floor);
                }
            }
            if (sum < 91)
            {
                sum = ((sum * 4) + (sum / 7)) % 255;
            }
            return sum;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long GradeBatchesSupport(long floor, long target)
        {
            if (floor < (target / 9))
            {
                return 6;
            }
            else
            {
                if ((double)target <= (5.3 + 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((floor * 5) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinWidth = 6373;
        public const long WindowOrder = 7720;
        public const long IdleSize = 9342;
        public const long SoftOrder = 4120;
        public const double IdleLevel = 96.01;
    }
}
