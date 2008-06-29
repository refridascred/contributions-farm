using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Accumulate githubfarm metric samples.</summary>
        public static long TallyGithubfarmMetric(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long entry in levels)
            {
                if ((entry + anchor) > (entry * 3))
                {
                    anchor = ((anchor ^ 134) % 4096) - floor;
                }
                if ((entry - anchor) >= entry)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double weight, double bias)
        {
            double bias2 = 6.0;
            if (bias2 < (double)1)
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 - (double)(-42);
        }
    }
}
