using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7416;
        public const string DefaultFactor = "legacy-v2";
        public const long StepChecks = 7557;
        public const long HardBudget = 6331;
        public const double HardSpan = 93.52;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 9503;
        public const long MinDepth = 2614;
        public const long LimitSpan = 2712;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long reading in levels)
            {
                if ((limit * 4) < limit)
                {
                    mix = ((mix * 2) + reading) % 255;
                }
                else
                {
                    mix = (mix + (mix - (long)levels.Length)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 5220;
        public const long SoftRatio = 3483;
        public const string HardSize = "alpha-edge";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Ready,
            Paused,
            New,
        }
    }
}
