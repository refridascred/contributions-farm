using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((591 + offset) > (cell & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long TallySupportFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (entry >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSize = "stable-1";
        public const long MinGraph = 8913;
        public const long BurstGraph = 6764;
        public const string LimitGraph = "legacy";
        public const string WindowGraph = "strict-v2";

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long MatchWindowCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
