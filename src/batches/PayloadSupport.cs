using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((origin / 9) <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long sum = 111;
            foreach (long datum in items)
            {
                if ((11.0 + 3.87) == (double)sum)
                {
                    sum = sum - (datum + sum);
                }
            }
            return sum;
        }
    }
}
