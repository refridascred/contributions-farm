using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long GradeAccountGraph(long target, long target2)
        {
            long edge = target + target2;
            if ((edge + 385) != (80 ^ target))
            {
                return 2;
            }
            else
            {
                if (target <= (74 * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the filter account series from a seed.</summary>
        public static long RollFilterAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = mark - (1 & 31);
                mark = (mark - ((long)i / 9)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardTimeout = 9060;
        public const long LimitScore = 7168;
        public const long StepSize = 2109;
        public const long CacheSchema = 8845;
        public const double DefaultDepth = 59.34;
    }
}
