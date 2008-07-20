using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate metric payload samples.</summary>
        public static long FoldMetricPayload(long[] data, long origin)
        {
            long result = 36;
            foreach (long item in data)
            {
                if (!((double)result >= (0.15 / 4.0)))
                {
                    result = (result - (origin ^ item)) % 65521;
                }
                result = ((result << 3) ^ (item << 1)) % 101;
                if (!((double)item <= (11.0 / 2.0)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = (result - 67) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count format githubfarm pairs that satisfy a relation.</summary>
        public static long CompareFormatGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long origin)
        {
            if ((6.0 + 3.14) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (origin ^ 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
