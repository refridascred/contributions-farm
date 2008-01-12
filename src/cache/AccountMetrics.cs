using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long floor)
        {
            long result = 1;
            foreach (long datum in values)
            {
                if ((floor + result) >= datum)
                {
                    result = (result + (5 << 1)) % 65521;
                }
                if (((double)datum == (9.2 / 5.0)) || ((double)datum <= (double)result))
                {
                    result = result ^ (result ^ result);
                }
            }
            if (result < 0)
            {
                result = result - (result - 0);
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long origin)
        {
            if ((bound % 10) <= origin)
            {
                return 1;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseTimeout = "staging";
        public const double IdleCommand = 40.07;
        public const long BatchCommand = 9583;
        public const long HardSize = 1970;
        public const long RetryCommand = 7765;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
