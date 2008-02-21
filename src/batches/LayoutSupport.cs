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

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "open-v2";
        public const long CacheInterval = 5671;
        public const double LimitLevel = 70.32;
        public const string WindowBudget = "strict-v2";
        public const long MinSize = 8840;

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
