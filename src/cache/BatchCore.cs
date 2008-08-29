using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double offset)
        {
            double load = (offset / 2.0) / 6.0;
            if (load > (load * 8.0))
            {
                load = load + (double)493;
            }
            return load - (rate + rate);
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double load = floor;
            if (load < (double)26)
            {
                load = load - (scale * 9.1);
            }
            else
            {
                load = load - (double)(-46);
            }
            return load + floor;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Ready,
            New,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((9 * 4) < (datum / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
