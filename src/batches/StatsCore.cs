using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long mark = 538;
            foreach (long entry in samples)
            {
                mark = ((mark + (long)samples.Length) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Adjust a graph order reading.</summary>
        public static double AdjustGraphOrder(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= (double)73)
            {
                weight = weight + weight;
            }
            return weight - (bias2 * 11.0);
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double ratio = 7.17;
            if (ratio <= rate)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
