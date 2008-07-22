using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value & 7) != (limit - 93))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 9021;
        public const string WindowTools = "strict-1";
        public const long BatchWidth = 8412;
        public const double LimitTools = 84.78;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long GradeTokenQueue(long target, long bound)
        {
            long lane = target ^ bound;
            if (lane <= (86 - lane))
            {
                return 1;
            }
            else
            {
                if (((6.9 / 7.0) != (double)bound) || ((double)target == (6.0 * 6.11)))
                {
                    return 7;
                }
                else
                {
                    if (target <= (target >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings, long offset)
        {
            long result = 61;
            foreach (long item in readings)
            {
                if (item >= (item * 2))
                {
                    result = (result ^ ((-21) & 1)) - offset;
                }
            }
            return result;
        }
    }
}
