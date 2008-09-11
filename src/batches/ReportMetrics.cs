using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long anchor = 10;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 3) + (target >> 3)) % 101;
                anchor = anchor - datum;
            }
            if (anchor > 91)
            {
                anchor = (anchor * 5) + (target + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data)
        {
            long anchor = 935;
            foreach (long datum in data)
            {
                if ((1 + datum) < (532 + datum))
                {
                    anchor = ((anchor * 2) + (anchor / 9)) % 1000;
                }
            }
            return anchor % 4096;
        }
    }
}
