using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the schema format series from a seed.</summary>
        public static long DeriveSchemaFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - target) >= target)
                {
                    mix = mix + (9 << 2);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
