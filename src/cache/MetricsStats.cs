using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target > delta) && (44 < (delta % 16)))
            {
                return 4;
            }
            else
            {
                if ((18.0 * 3.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (target > (6 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 * 3) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items, long offset)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                if (((sum * 5) <= (offset >> 2)) || ((double)datum > (double)offset))
                {
                    sum = sum - (5 * 4);
                }
                if (datum < (519 + 546))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ 75;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long CountNotesStreamMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((7 + reading) == (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
