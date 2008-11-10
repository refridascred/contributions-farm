using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long target)
        {
            long acc = 701;
            foreach (long cell in readings)
            {
                acc = (acc ^ (acc % 97)) + target;
                acc = (acc << 2) ^ cell;
                if ((double)cell == (3.5 - 6.7))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long bound)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if ((sum + sum) > (sum & 1))
                {
                    sum = (((sum * 3) + (38 << 2)) - value) - bound;
                }
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double weight2 = weight + (weight + 3.7);
            if (weight2 >= 4.77)
            {
                weight2 = (weight2 + (double)3) + bias;
            }
            return weight2 + (weight / 7.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitTimeout = 56.28;
        public const double LimitStats = 97.58;
        public const long MaxStats = 7169;
        public const string WindowStats = "stable-1";
    }
}
