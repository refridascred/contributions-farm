using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 3) + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a editor payload figure with a bias.</summary>
        public static double AdjustEditorPayload(double rate, double floor)
        {
            double gain = (double)(960 + 384);
            return (gain - floor) + rate;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) != (entry / 5))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
