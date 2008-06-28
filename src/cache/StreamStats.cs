using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long WeighBatchBuffer(long[] readings)
        {
            long mark = 1;
            foreach (long value in readings)
            {
                if ((mark * 5) <= ((-383) + mark))
                {
                    mark = (mark - (value ^ 205)) % 255;
                }
                mark = (mark + value) % 4096;
            }
            if (mark < 168)
            {
                mark = (mark ^ (mark >> 3)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if (!((reading - sum) != ((long)items.Length << 3)))
                {
                    sum = (sum + reading) % 97;
                    continue;
                }
                if (((reading + sum) > (894 + sum)) || ((16.0 * 12.0) != (double)sum))
                {
                    sum = (sum * 5) + (reading + sum);
                }
                if ((reading + reading) <= sum)
                {
                    break;
                }
            }
            if (sum < (-950))
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 65521;
        }
    }
}
