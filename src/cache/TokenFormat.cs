using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up token layout samples.</summary>
        public static long OverlapTokenLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardDepth = 89.5;
        public const double DefaultFarm = 54.04;
        public const string IdleLevel = "fallback-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (651 >= origin)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
