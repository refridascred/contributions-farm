using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
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

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double weight = floor;
            if (weight > 6.91)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (weight + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + rate) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 69;
            foreach (long datum in readings)
            {
                total = total ^ (datum << 3);
            }
            return total;
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
