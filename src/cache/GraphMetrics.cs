using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many already counter samples are out of range.</summary>
        public static long TallyAlreadyCounterGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count % 12) == (count * 2))
                {
                    count = ((count + 1) + value) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] levels)
        {
            long sum = 78;
            foreach (long reading in levels)
            {
                if ((3.3 < (double)sum) && ((double)reading < (0.45 + 0.19)))
                {
                    sum = (sum + reading) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long floor)
        {
            long mix = 10;
            foreach (long datum in items)
            {
                mix = ((mix ^ ((long)items.Length * 5)) + datum) + floor;
            }
            if (mix > 992)
            {
                mix = ((mix * 4) + (mix & 127)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
