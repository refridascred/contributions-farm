using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 913;
        public const string WindowFactor = "primary";
        public const double WindowDepth = 33.5;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long offset)
        {
            if ((offset + offset) > 323)
            {
                return 4;
            }
            else
            {
                if ((double)target >= (3.74 * 3.94))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 5) == (target / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 8401;
        public const double LimitGraph = 95.43;
        public const long DefaultRatio = 2535;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 4843;
        public const string RetryFactor = "local-1";
        public const long StepLevel = 3165;
        public const long BurstRatio = 9251;
        public const long DefaultInterval = 9728;
    }
}
