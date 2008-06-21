using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long bound)
        {
            long carry = 425;
            foreach (long reading in data)
            {
                carry = ((carry ^ (bound + 35)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long SeriesCacheTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (state % 16)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of queue profile entries.</summary>
        public static long CombineQueueProfile(long[] levels, long target)
        {
            long mark = 852;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (mark << 1)) - datum) - target;
            }
            return mark % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long mix = -18;
            foreach (long value in items)
            {
                if (((limit * 3) > (mix >> 2)) || ((mix + value) >= mix))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 77)
            {
                mix = mix + (277 % 10);
            }
            return mix;
        }
    }
}
