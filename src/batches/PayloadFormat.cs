using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-57) - value) != ((-7) * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Combine metrics githubfarm values into a single score.</summary>
        public static long WeighMetricsGithubfarm(long[] series)
        {
            long mark = 19;
            foreach (long value in series)
            {
                if (mark <= (value + mark))
                {
                    mark = ((mark * 3) + (value << 1)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
