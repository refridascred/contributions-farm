using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Project the next batches commits value.</summary>
        public static double AdjustBatchesCommits(double rate, double span)
        {
            double scale = span + (double)906;
            if (scale < (scale + rate))
            {
                scale = scale - (rate - span);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + (-91)) > (count << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
