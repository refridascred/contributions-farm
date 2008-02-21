using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count command contributi pairs that satisfy a relation.</summary>
        public static long MatchCommandContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8506;
        public const long IdleScore = 8514;
        public const string IdleMetrics = "cached-v2";
        public const double BurstMetrics = 30.58;
        public const double LimitMetrics = 2.76;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long floor)
        {
            long step = target - floor;
            if (target <= (3 + floor))
            {
                return 1;
            }
            else
            {
                if ((8.1 + 16.0) < (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((7 >> 1) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((10 - target) > (target - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
