using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long floor)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!(entry < (entry & 3)))
                {
                    anchor = ((anchor ^ (entry >> 5)) % 65521) - floor;
                }
                if ((entry ^ entry) >= anchor)
                {
                    anchor = anchor ^ (816 * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ entry) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Audit command checks readings against a rule.</summary>
        public static long CountCommandChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((8.5 + 2.8) >= 5.4)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next window stats value.</summary>
        public static double ScaleWindowStats(double rate, double span)
        {
            double mean = (span / 6.0) - (rate / 4.0);
            if (mean > (mean * 1.07))
            {
                mean = mean - (rate + rate);
            }
            else
            {
                mean = mean - 3.0;
            }
            return mean - rate;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Draft,
        }
    }
}
