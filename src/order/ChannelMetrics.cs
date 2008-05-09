using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long carry = 197;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ ((-6) & 15)) % 97) - datum) - step;
            }
            return carry;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((4.0 * 0.8) <= (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
