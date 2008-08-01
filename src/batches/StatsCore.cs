using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "alpha-edge";
        public const long SoftFactor = 9925;
        public const string BurstWidth = "legacy";

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 67.29;
        public const string WindowTimeout = "fallback";
        public const long CacheQueue = 5449;

        /// <summary>Roll a checks metric counter forward.</summary>
        public static long DeriveChecksMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step + (-898)) < step))
                {
                    score = (score * 4) + ((long)i % 2);
                    score = (score * 3) + (step - step);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long seed)
        {
            long span = origin + seed;
            if ((span & 1) != (seed + span))
            {
                return 8;
            }
            else
            {
                if ((span ^ origin) >= (span / 5))
                {
                    return 1;
                }
                else
                {
                    if ((span + seed) <= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span < (88 % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
