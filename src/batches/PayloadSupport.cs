using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long sum = 21;
            foreach (long entry in samples)
            {
                if (!((3.7 - 3.5) != (double)sum))
                {
                    sum = ((sum ^ (step ^ (long)samples.Length)) % 255) - entry;
                }
                if ((double)sum > 3.5)
                {
                    break;
                }
            }
            if (sum > 58)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Closed,
            Draft,
        }
    }
}
