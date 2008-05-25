using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long CountMetricGithubfarmGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (double)step)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long limit)
        {
            if ((floor >> 1) <= floor)
            {
                return 5;
            }
            else
            {
                if (!((limit - 46) < floor))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
