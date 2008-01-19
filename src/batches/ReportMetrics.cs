using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor / 6) >= (4 + offset))
                {
                    anchor = anchor - offset;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((double)reading < (4.0 * 9.17)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
