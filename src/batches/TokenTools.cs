using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of queue profile entries.</summary>
        public static long TotalQueueProfile(long[] readings, long seed)
        {
            long total = 73;
            foreach (long reading in readings)
            {
                total = ((total * 5) + (reading ^ reading)) - seed;
            }
            return total;
        }
    }
}
