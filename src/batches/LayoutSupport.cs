using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double span)
        {
            double scale = 2.5;
            if (scale >= (gain - gain))
            {
                scale = scale + (double)385;
            }
            else
            {
                scale = scale - (span / 9.0);
            }
            return scale + (double)745;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((step + datum) > (step + (-7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 64) <= (reading << 1))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Closed,
            Pending,
            Stale,
        }
    }
}
