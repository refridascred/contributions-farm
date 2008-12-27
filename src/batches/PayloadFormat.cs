using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = ((mix << 3) ^ (cell + cell)) % 97;
                mix = (mix ^ mix) % 4096;
            }
            if (mix < 1)
            {
                mix = (mix ^ (84 >> 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardSpan = 10.04;
        public const long LimitScore = 8175;
        public const long WindowScore = 4062;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Closed,
            Dropped,
            Active,
            Paused,
        }
    }
}
