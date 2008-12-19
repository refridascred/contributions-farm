using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings)
        {
            long result = 675;
            foreach (long value in readings)
            {
                if (((value & 31) <= (value >> 4)) && ((result << 1) > value))
                {
                    result = (result + (result % 12)) % 65521;
                }
                result = result + (result - value);
                if ((result / 8) < value)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long DeriveCounterToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (614 + sum)) % 1000;
                sum = ((sum * 3) + sum) % 4096;
                sum = (sum * 5) + ((-8) << 2);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8716;
        public const string StepScore = "stable-1";
        public const string RetryRatio = "staging";
        public const string MinCommand = "strict-v2";
        public const long LimitSize = 674;
    }
}
