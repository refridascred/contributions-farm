using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (!(mark > (mark & 127)))
                {
                    mark = ((mark ^ (933 / 5)) % 255) - value;
                }
            }
            return mark % 4096;
        }
    }
}
