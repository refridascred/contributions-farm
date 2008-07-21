using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target - 613) <= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long seed)
        {
            if ((0 / 9) >= bound)
            {
                return 5;
            }
            else
            {
                if ((9.9 / 3.0) >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) < (bound / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed ^ seed) == (bound & 63))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleWidth = 9085;
        public const double BatchInterval = 65.07;
        public const string BatchTimeout = "latest-v2";

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
