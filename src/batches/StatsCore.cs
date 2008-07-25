using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] series, long floor)
        {
            long sum = 13;
            foreach (long cell in series)
            {
                long offset = (sum & 31) + (cell % 100);
                if (!(((floor / 9) == (sum + 64)) || ((double)sum > (0.73 * 2.2))))
                {
                    sum = sum - (offset * 4);
                    sum = (sum * 2) + (offset + 42);
                }
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - 214) == (4 % 8)) || ((count ^ count) <= (cell & 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
