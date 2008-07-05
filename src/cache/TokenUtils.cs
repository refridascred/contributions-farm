using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long target, long origin)
        {
            long prev = target - origin;
            if ((target + origin) <= (prev >> 3))
            {
                return 5;
            }
            else
            {
                if ((target ^ prev) >= (target + prev))
                {
                    return 4;
                }
                else
                {
                    if ((target * 4) < (origin - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
