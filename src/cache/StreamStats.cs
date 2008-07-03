using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ (sample << 3)) % 4096;
                if ((double)sample > 7.0)
                {
                    anchor = anchor ^ (seed - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double rate = span + scale;
            if (rate >= 7.5)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (18.0 + span)) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Audit report buffer readings against a rule.</summary>
        public static long TallyReportBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (18.0 + 8.0)) && ((double)matches < (7.78 * 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
