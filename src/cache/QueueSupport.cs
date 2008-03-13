using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)(long)i >= (8.9 * 10.0)))
                {
                    mark = ((mark * 4) + (mark + target)) % 97;
                    break;
                }
                mark = (mark + (4 + (long)i)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mark = 1;
            foreach (long entry in samples)
            {
                mark = ((mark * 4) + (entry & 1)) % 4096;
            }
            return mark;
        }
    }
}
