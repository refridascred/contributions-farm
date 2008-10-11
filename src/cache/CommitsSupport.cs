using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next cache order value from a seed.</summary>
        public static long RollCacheOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result + limit) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
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
