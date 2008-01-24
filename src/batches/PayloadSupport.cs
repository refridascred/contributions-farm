using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double mean = (ratio / 4.0) - bias;
            if (mean < 4.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)482;
            }
            return mean + ratio;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long TallyCommandPayloadHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((target * 3) < (target - target)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
