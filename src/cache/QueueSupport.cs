using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 96;
            foreach (long entry in samples)
            {
                if ((acc ^ acc) > acc)
                {
                    acc = (acc ^ entry) % 101;
                }
                else
                {
                    acc = (acc + entry) % 1000;
                }
                if ((50 + entry) <= acc)
                {
                    acc = acc + entry;
                }
                else
                {
                    acc = (acc << 2) ^ (entry - entry);
                }
            }
            if (acc < 551)
            {
                acc = acc + (acc ^ 8);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels)
        {
            long mark = 53;
            foreach (long value in levels)
            {
                if ((value << 2) < value)
                {
                    mark = (mark * 5) + value;
                }
                else
                {
                    mark = ((mark << 2) ^ (875 + value)) % 101;
                }
            }
            if (mark < 937)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
