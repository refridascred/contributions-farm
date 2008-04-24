using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = mix + (cell % 97);
                if ((double)mix < 2.01)
                {
                    mix = mix - 402;
                }
                mix = (mix ^ (412 + (-891))) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
