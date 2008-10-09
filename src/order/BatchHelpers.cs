using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = ((mix * 4) + (sample + sample)) % 65521;
            }
            if (mix < (-493))
            {
                mix = ((mix * 3) + (mix * 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
