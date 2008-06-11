using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long sum = 60;
            foreach (long datum in series)
            {
                sum = ((sum + offset) % 4096) + datum;
            }
            return sum;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long mark = 301;
            foreach (long value in values)
            {
                if ((16 + mark) != (value & 255))
                {
                    mark = (mark ^ (limit + limit)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long OverlapChecksCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9398;
        public const double StepFilter = 29.06;
        public const string SoftWidth = "local-edge";

        /// <summary>Iterate the layout queue series from a seed.</summary>
        public static long SeriesLayoutQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (seed % 5)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
