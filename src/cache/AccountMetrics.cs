using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count layout already pairs that satisfy a relation.</summary>
        public static long MatchLayoutAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSize = 7912;
        public const string StepCluster = "cached-edge";
        public const long LimitScore = 3147;
        public const double StepInterval = 12.44;

        /// <summary>Fold a list of support order readings.</summary>
        public static long WeighSupportOrder(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum + (origin + entry)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(score <= (origin - score)))
                {
                    break;
                }
                if ((double)score > (13.0 / 7.0))
                {
                    score = (score - (origin - 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 6957;
        public const long BatchMetrics = 8369;
        public const string MaxMetrics = "open-edge";
        public const string BurstMetrics = "fallback-v2";
        public const string BaseInterval = "strict-1";
    }
}
