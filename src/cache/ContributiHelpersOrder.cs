using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (9 ^ target);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 8191;
        public const long BurstProfile = 7939;
        public const long IdleProfile = 6670;
        public const long BaseProfile = 911;
        public const long LimitRatio = 5092;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
