using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long StepCounterFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ ((long)i + carry);
                carry = carry - (67 - floor);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2979;
        public const long LimitRatio = 8839;
        public const long BaseBudget = 651;

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total * 4) + (offset + total)) + (long)i2;
                }
                if (((total ^ offset) < offset) && (total >= offset))
                {
                    continue;
                }
                else
                {
                    total = ((total * 2) + (offset % 12)) % 101;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) < (12 % 24))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
