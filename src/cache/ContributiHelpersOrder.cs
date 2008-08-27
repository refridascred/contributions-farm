using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepRatio = 2667;
        public const long BatchFarm = 3896;
        public const double CacheFarm = 35.86;
        public const string MinDepth = "stable-1";
    }
}
