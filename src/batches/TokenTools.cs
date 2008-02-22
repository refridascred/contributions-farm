using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally > (sample + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 6607;
        public const double CacheSpan = 71.69;
        public const double HardSpan = 82.38;
        public const string IdleDepth = "stable-1";
    }
}
