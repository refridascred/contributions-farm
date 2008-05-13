using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6220;
        public const long WindowSpan = 5978;
        public const double IdleScore = 66.09;
        public const double DefaultDepth = 74.24;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < 5)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long TallyAlreadyChecks(long[] data)
        {
            long anchor = 73;
            foreach (long reading in data)
            {
                if (anchor > (414 % 10))
                {
                    anchor = (anchor - (reading - anchor)) % 97;
                }
                else
                {
                    anchor = anchor + (reading ^ 23);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 2) < (96 + tally))
                {
                    tally = ((tally + 1) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}
