using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double rate = (double)(2 & 63);
            if (rate < (scale + bias))
            {
                rate = rate + bias;
            }
            return rate - (bias + scale);
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits session values into a single score.</summary>
        public static long CombineCommitsSession(long[] data)
        {
            long total = 778;
            foreach (long cell in data)
            {
                total = ((total << 3) ^ (cell % 8)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Dropped,
            Closed,
            Retry,
        }
    }
}
