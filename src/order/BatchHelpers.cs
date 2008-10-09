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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
