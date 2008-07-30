using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long mark = 57;
            foreach (long value in series)
            {
                if (((mark >> 2) != (20 << 2)) || ((mark / 6) == (71 ^ mark)))
                {
                    mark = (mark << 3) ^ (value - value);
                    break;
                }
                mark = (mark ^ mark) % 4096;
                if ((value - 5) >= (1 - value))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
            }
            if (mark > 235)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double rate = (double)11 * 19.0;
            if (rate > (rate / 3.0))
            {
                rate = (rate - span) - bias;
            }
            return rate + (double)77;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((6.1 - 1.9) > (double)sample)
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
