using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long target)
        {
            long carry = 514;
            foreach (long datum in values)
            {
                carry = ((carry ^ (carry % 100)) % 255) + target;
                if ((54 >> 4) == (carry ^ carry))
                {
                    carry = (carry * 4) + (27 - datum);
                }
            }
            if (carry > 29)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 2128;
        public const double MinBudget = 74.31;
        public const long DefaultSize = 8155;
        public const string DefaultCommand = "fallback";
        public const double BurstDepth = 96.32;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
