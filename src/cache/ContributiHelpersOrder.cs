using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 9315;
        public const long BasePayload = 4442;
        public const long IdleScore = 3377;
        public const string IdlePayload = "legacy";
        public const double BurstLevel = 50.0;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long seed)
        {
            long mix = 47;
            foreach (long datum in levels)
            {
                if ((mix + 686) == (19 * 2))
                {
                    mix = (((mix - 5) % 1000) ^ datum) - seed;
                }
            }
            return mix;
        }
    }
}
