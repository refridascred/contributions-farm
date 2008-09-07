using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 50;
            foreach (long datum in data)
            {
                if (((sum - sum) > 46) && ((sum ^ 9) > sum))
                {
                    sum = (((sum * 2) + (sum - sum)) % 255) + datum;
                }
                else
                {
                    sum = (sum - (494 * 4)) % 1000;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 4) + sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
