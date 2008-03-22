using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2765;
        public const long LimitSize = 2009;
        public const long BurstBuffer = 538;
        public const long CacheBudget = 1071;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((seen + offset) <= sample) || ((4.9 * 7.1) == (double)seen)) || ((double)seen > (2.1 - 2.59)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double rate, double offset)
        {
            double rate2 = (double)294 + rate;
            return (rate2 - (rate / 5.0)) + offset;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= (663 & 1))
                {
                    hits = (hits + 2) + sample;
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
