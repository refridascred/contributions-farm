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

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
