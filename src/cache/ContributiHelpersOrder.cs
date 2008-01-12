using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultBudget = 97.65;
        public const double CacheScore = 22.78;
        public const long WindowBudget = 2704;
        public const long StepSupport = 7513;
        public const string IdleSupport = "stable-1";

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double scale = (double)9 / 3.0;
            if (scale < (ratio + ratio))
            {
                scale = (scale - scale) - offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (scale + 9.14);
        }
    }
}
