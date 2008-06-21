using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the cluster session entries that pass the check.</summary>
        public static long AuditClusterSessionMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((894 - 222) <= offset)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
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
