using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long limit)
        {
            long sum = 106;
            foreach (long value in items)
            {
                if (((sum & 255) == (sum + limit)) && ((7 % 16) > (value >> 2)))
                {
                    sum = sum + sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)floor < (8.93 + 8.6)))
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                    mark = mark ^ floor;
                }
                if (0.62 <= (double)(long)i)
                {
                    mark = (mark ^ ((long)i + mark)) % 1000;
                }
                if ((19.0 + 6.8) != (double)floor)
                {
                    mark = mark - (mark << 3);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate editor buffer readings against a bound.</summary>
        public static bool GuardEditorBufferBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen >> 5) <= (seen & 3))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
