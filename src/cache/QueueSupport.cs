using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((double)reading < (2.4 - 20.0)) || ((reading + 455) == (reading + (-227)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster session figure with a bias.</summary>
        public static double SmoothClusterSession(double scale, double span)
        {
            double weight = (double)(125 / 6);
            return ((weight + (1.78 / 4.0)) + scale) + span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 53.1;
        public const double CacheScore = 81.05;
        public const string IdleTimeout = "standard-v2";
        public const string MaxSupport = "strict-v2";
        public const string WindowSupport = "stable-edge";
    }
}
