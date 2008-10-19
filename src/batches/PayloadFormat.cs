using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context farm input into a small class.</summary>
        public static long GradeContextFarm(long seed, long offset)
        {
            if ((offset >> 5) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)seed < (0.16 - 7.6))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 2201;
        public const double BurstAccount = 81.67;
        public const double IdleAccount = 52.82;
    }
}
