using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long seed, long origin)
        {
            long span = seed - origin;
            if (((span >> 1) >= (129 ^ seed)) || ((double)span <= (17.0 * 2.6)))
            {
                return 6;
            }
            else
            {
                if (((seed + span) != (span % 8)) && ((origin % 60) >= origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 6839;
        public const double SoftFilter = 65.87;
        public const long HardSize = 5201;
        public const long DefaultFilter = 3045;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8343;
        public const long HardCommand = 1370;
        public const double WindowScore = 11.8;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftFactor = 3977;
        public const long DefaultStream = 5374;
        public const long BatchStream = 629;
        public const long StepSize = 4848;
        public const double BurstFactor = 80.42;
    }
}
