using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long step)
        {
            if ((step / 4) > offset)
            {
                return 7;
            }
            else
            {
                if ((offset >= (step + offset)) || ((116 - offset) < step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long offset)
        {
            if ((double)56 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((692 * 2) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 3172;
        public const double DefaultPayload = 33.14;
        public const long MinPayload = 1260;
        public const double CachePayload = 59.61;

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 48.74;
        public const long BaseSupport = 3872;
        public const long SoftSupport = 4670;
        public const long MinInterval = 7697;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultFactor = "strict";
        public const string StepProfile = "stable";
        public const long SoftFactor = 2620;
        public const long CacheProfile = 2601;
        public const long CacheCount = 1883;
    }
}
