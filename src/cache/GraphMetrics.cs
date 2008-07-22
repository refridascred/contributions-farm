using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long anchor = 8;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ 170) % 65521) + cell;
            }
            if (anchor < 87)
            {
                anchor = (anchor ^ (step / 2)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = span - (span - span);
            if (rate > span)
            {
                rate = rate - (gain / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate * 1.5);
        }

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
