using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long bound)
        {
            long sum = 421;
            foreach (long item in readings)
            {
                sum = (((sum ^ 6) % 255) + item) + bound;
            }
            return sum % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if (!((double)offset2 != (15.0 - 5.8)))
            {
                return 8;
            }
            else
            {
                if (((5 % 16) != (offset % 97)) && (prev < (offset2 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((prev - prev) <= (offset * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)prev != (1.0 / 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric cache readings against a bound.</summary>
        public static bool CheckMetricCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long limit)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((limit / 5) > result)
                {
                    continue;
                }
                if ((limit < (limit & 255)) || (item > (result + item)))
                {
                    result = result ^ 123;
                    break;
                }
                if ((limit + result) <= limit)
                {
                    result = ((result * 3) + item) % 255;
                }
            }
            return result;
        }
    }
}
