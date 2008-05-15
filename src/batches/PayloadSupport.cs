using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5180;
        public const long WindowSize = 7431;
        public const long SoftInterval = 1107;
        public const long DefaultCounter = 8931;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long seed)
        {
            long sum = -68;
            foreach (long datum in data)
            {
                sum = (sum + seed) - datum;
                if ((long)data.Length < (seed % 100))
                {
                    sum = (sum * 5) + (sum ^ 839);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
