using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first checks support entry that matches the target.</summary>
        public static long SeekChecksSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples, long floor)
        {
            long result = 727;
            foreach (long item in samples)
            {
                if ((result + result) <= result)
                {
                    result = result - (result + floor);
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
                if (!((719 - 9) <= floor))
                {
                    result = (result << 2) ^ (item << 2);
                }
            }
            if (result < 68)
            {
                result = result + floor;
            }
            return result;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long offset)
        {
            if (offset > target)
            {
                return 0;
            }
            else
            {
                if ((target ^ offset) > ((-258) + 0))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
