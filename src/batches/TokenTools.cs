using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stats checks counter forward.</summary>
        public static long StepStatsChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (target >> 4)) % 4096;
                if (!((target * 4) == (sum % 3)))
                {
                    sum = (sum + target) % 65521;
                }
                if ((double)target >= 14.0)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheTimeout = 20.13;
        public const string HardSchema = "strict-edge";
        public const string BurstScore = "strict";
        public const long WindowSchema = 8412;
        public const long StepSchema = 2822;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
