using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + ((long)i * 4)) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 4;
            foreach (long sample in series)
            {
                sum = ((sum * 3) + (sample / 6)) % 255;
                sum = (sum - (sum + sum)) % 97;
            }
            if (sum > 73)
            {
                sum = (sum * 3) + (sum - 94);
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 93.82;
        public const string StepProfile = "cached-v2";
        public const long WindowProfile = 9452;
        public const long DefaultProfile = 8108;
        public const double LimitLevel = 61.14;
    }
}
