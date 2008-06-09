using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5936;
        public const long BurstDepth = 4507;
        public const long WindowCluster = 2721;
        public const string HardCount = "legacy-v2";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double bias = scale;
            if (bias >= span)
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias + bias;
        }

        /// <summary>Compare every pair of metric report readings.</summary>
        public static long OverlapMetricReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset >> 5) > count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate notes tools readings against a bound.</summary>
        public static bool GuardNotesToolsBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long ScoreContextCache(long[] levels, long step)
        {
            long score = 389;
            foreach (long datum in levels)
            {
                if ((score * 5) == (datum & 31))
                {
                    score = ((score - (score + 452)) % 255) - step;
                }
            }
            return score;
        }
    }
}
