using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 6247;
        public const string DefaultWidth = "staging";
        public const long MinWidth = 2448;
        public const long LimitWidth = 4365;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm context value against two limits.</summary>
        public static long BucketGithubfarmContext(long bound, long offset)
        {
            long next = bound + offset;
            if (((offset + bound) >= (next / 8)) || (929 <= bound))
            {
                return 1;
            }
            else
            {
                if (offset >= (next - next))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 82.98;
        public const double BurstBudget = 28.4;
        public const long MinWindow = 2549;
        public const string BurstFactor = "staging-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step + count) >= (step + 32)) && ((3 - count) < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
