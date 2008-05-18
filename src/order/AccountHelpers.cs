using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 3) > reading) || (((reading << 3) == (reading + reading)) || ((double)(long)series.Length != (6.6 * 7.03))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double bias = (double)(812 + 84);
            if (bias >= (weight * 3.0))
            {
                bias = bias - (span * 2.1);
            }
            else
            {
                bias = bias + (span / 5.0);
            }
            return bias - (weight / 4.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound / 9) < (bound << 2))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (seed <= 962)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
