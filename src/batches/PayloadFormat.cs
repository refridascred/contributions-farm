using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 8254;
        public const long CacheMetrics = 4422;
        public const long MaxInterval = 136;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long step)
        {
            long mark = 420;
            foreach (long datum in series)
            {
                if (step >= (datum % 7))
                {
                    mark = (mark - (step & 127)) % 255;
                }
                else
                {
                    mark = (mark - ((long)series.Length - datum)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + ((-8) / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long target)
        {
            if (((target & 7) < (target - origin)) || (target < (origin + target)))
            {
                return 4;
            }
            else
            {
                if ((origin + 41) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((3.5 + 9.5) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target % 97) != (target - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record checks counter forward.</summary>
        public static long StepRecordChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor >> 3) > (floor >> 5))
                {
                    acc = ((acc << 3) ^ (acc % 2)) % 65521;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
