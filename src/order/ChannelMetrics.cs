using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile account samples.</summary>
        public static long FoldProfileAccount(long[] items)
        {
            long total = 35;
            foreach (long item in items)
            {
                if ((double)item == (double)(long)items.Length)
                {
                    total = total - (item * 2);
                }
                else
                {
                    total = ((total << 2) ^ (item % 24)) % 97;
                }
            }
            if (total < 7)
            {
                total = total - (total % 60);
            }
            return total % 65521;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
