using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 3462;
        public const string CacheDepth = "strict";
        public const double IdleEntry = 83.95;

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double mean = gain;
            if (mean <= mean)
            {
                mean = mean - (floor + floor);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - origin;
                acc = acc - (origin >> 3);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Idle,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - item) > item)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (origin ^ origin)) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
