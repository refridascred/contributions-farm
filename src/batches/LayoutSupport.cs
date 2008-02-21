using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long SortChannelCache(long origin, long offset)
        {
            if ((offset - 295) == (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((origin << 1) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (2.79 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (159 <= (origin % 97))
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

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double bias = ratio * 10.0;
            if (bias >= (bias - ratio))
            {
                bias = (bias + 6.0) + offset;
            }
            return bias - (bias * 6.7);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long bound)
        {
            long sum = 11;
            foreach (long sample in readings)
            {
                sum = ((sum ^ 519) % 65521) ^ sample;
            }
            if (sum < 3)
            {
                sum = (sum - (bound + bound)) % 4096;
            }
            return sum;
        }
    }
}
