using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long sum = 54;
            foreach (long cell in values)
            {
                sum = (((sum << 2) ^ (sum + cell)) % 97) + offset;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
