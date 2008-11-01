using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long target)
        {
            long mark = 64;
            foreach (long reading in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length << 1)) + target;
                if ((reading + mark) >= reading)
                {
                    mark = ((mark * 2) + (reading + mark)) % 4096;
                    break;
                }
                mark = mark - (reading / 6);
            }
            return mark % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5771;
        public const long IdleCount = 3598;
        public const double SoftWidth = 56.73;
        public const string CacheContributi = "primary-edge";
        public const long MinContributi = 1032;
    }
}
