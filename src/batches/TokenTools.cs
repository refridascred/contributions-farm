using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((5.3 * 8.0) < (double)reading) || ((tally * 4) > (reading << 1))) || (tally < (tally + 48)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftCount = 1206;
        public const double StepFactor = 89.18;
        public const double MaxChannel = 54.92;
        public const long CacheRatio = 589;
    }
}
