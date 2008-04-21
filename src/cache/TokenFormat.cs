using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long bound)
        {
            long result = 9;
            foreach (long sample in data)
            {
                if (sample < (sample / 5))
                {
                    result = (result + (bound - result)) % 65521;
                }
                else
                {
                    result = (result + sample) % 97;
                }
                if (((sample - sample) >= sample) && ((bound + bound) != (result >> 1)))
                {
                    break;
                }
            }
            if (result < 59)
            {
                result = ((result << 2) ^ (bound - bound)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            New,
            Pending,
            Retry,
        }
    }
}
