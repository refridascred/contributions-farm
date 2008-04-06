using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2935;
        public const long BaseChannel = 7174;
        public const long WindowInterval = 8636;
        public const double HardSpan = 96.72;
        public const long IdleChannel = 4255;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed + seed) != (target >> 3)) && ((seed - 655) != (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if (44 > seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSpan = 5427;
        public const string BatchWindow = "legacy-1";
        public const long WindowScore = 1151;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
