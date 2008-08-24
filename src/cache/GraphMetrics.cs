using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 9534;
        public const double HardSpan = 75.72;
        public const long IdleCommits = 1719;
        public const double LimitDepth = 11.5;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double load = 3.4 - span;
            if (load < (0.56 * 5.98))
            {
                load = load + ratio;
            }
            else
            {
                load = load - span;
            }
            return load - 7.4;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (0.16 > (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long result = -914;
            foreach (long cell in samples)
            {
                result = (result + result) % 4096;
                result = (result ^ (origin * 3)) % 1000;
                result = (result << 2) ^ (cell + cell);
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Draft,
            Idle,
        }
    }
}
