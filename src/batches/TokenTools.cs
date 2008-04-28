using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (seed < (datum % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally < (tally + seed)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
