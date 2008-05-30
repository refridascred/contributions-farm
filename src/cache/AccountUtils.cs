using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 8.19;
        public const long IdleCount = 8079;
        public const long MinDepth = 9616;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + step) < (step << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
