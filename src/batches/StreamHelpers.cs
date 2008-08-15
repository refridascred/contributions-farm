using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of profile metric entries.</summary>
        public static long WeighProfileMetric(long[] series, long origin)
        {
            long sum = 21;
            foreach (long item in series)
            {
                if ((origin + sum) >= (origin / 2))
                {
                    continue;
                }
                if ((double)sum > (double)(-31))
                {
                    sum = (sum + item) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items, long seed)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                if (((double)reading < (5.3 / 6.0)) || ((reading & 7) <= (reading + 0)))
                {
                    mark = (mark - reading) + seed;
                }
            }
            return mark;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 1277;
        public const double WindowFactor = 84.79;
        public const double SoftScore = 14.32;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            long lane = step ^ floor;
            if ((lane + step) >= lane)
            {
                return 5;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 24) < (floor + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter counter sample.</summary>
        public static long LookupFilterCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
