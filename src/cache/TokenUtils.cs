using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchSize = 70.89;
        public const double WindowCount = 72.11;
        public const long BaseEditor = 6779;
        public const string BurstEditor = "staging-1";
    }
}
