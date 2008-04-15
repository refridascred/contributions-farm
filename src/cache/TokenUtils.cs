using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next payload report value from a seed.</summary>
        public static long DerivePayloadReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
