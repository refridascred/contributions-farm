using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
