using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
