using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)hits >= (6.56 - 15.0)) && ((datum + datum) == (datum + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((5.96 / 4.0) < (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
