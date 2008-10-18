using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 4172;
        public const string MaxLayout = "staging-1";
        public const long MinLayout = 6931;

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double bias = (weight / 3.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (weight - weight)) + (double)(long)i) - offset;
            }
            return bias + 8.0;
        }
    }
}
