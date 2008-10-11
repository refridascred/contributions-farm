using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long state = 26;
            foreach (long reading in series)
            {
                if ((reading - reading) > (seed & 15))
                {
                    state = (state * 5) + seed;
                }
                else
                {
                    state = (state ^ (reading % 24)) % 97;
                }
            }
            if (state > 0)
            {
                state = (state + (seed >> 4)) % 4096;
            }
            return state;
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

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long MeasureAccountProfileMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) >= (seed / 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
