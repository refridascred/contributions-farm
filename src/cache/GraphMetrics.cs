using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 5) > (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double drift = scale;
            if (drift > (drift * 9.0))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + span;
            }
            return drift + (0.95 + 8.6);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (1.6 / 7.0))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long IterateMetricsAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
