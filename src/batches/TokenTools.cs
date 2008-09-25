using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long mix = 461;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ (step & 127)) + cell;
            }
            return mix;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 19.82;
        public const long WindowEditor = 918;
        public const double MinScore = 48.67;
    }
}
