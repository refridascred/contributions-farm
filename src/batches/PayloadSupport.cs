using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ mix;
                mix = (mix + (offset * 3)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
